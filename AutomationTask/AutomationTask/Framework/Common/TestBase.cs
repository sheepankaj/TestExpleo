using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Xunit;

namespace AutomationTask.Framework.Common
{
    public abstract class TestBase : IDisposable
    {
        #region Driver Setup
        public static IWebDriver driver;

        /// <summary>
        /// Gets the Driver from CreateBrowserDriver method
        /// </summary>

        protected TestBase()
        {
            driver = CreateBrowserDriver("chrome");
        }
        #endregion Driver Setup

        #region Dispose test execution after test done
        /// <summary>
        /// Dispose the test after we are done
        /// </summary>
        public virtual void Dispose()
        {
            driver.Quit();
        }
        #endregion


        #region Browser SetUp
        /// <summary>
        /// Generate a browser driver for test
        /// </summary>
        /// <param name="BrowserDriver"></param>
        /// <returns></returns>
        private static IWebDriver CreateBrowserDriver(string browserDriver)
        {

            if (browserDriver == null) return new ChromeDriver();

            switch (browserDriver)
            {
                case "chrome":
                    ChromeOptions chrome = new ChromeOptions();
                    chrome.AddArgument("--start-maximized");

                    return new ChromeDriver(chrome);

                default:
                    throw new Exception("Cannot find browser driver with the name: " + browserDriver);

            }

        }

        #endregion

        #region Go to URl and open it in the browser
        /// <summary>
        /// Open an browser in the browser
        /// </summary>
        /// <param name="url"></param>
        public void VisitUrl(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                Wait().Until(ExpectedConditions.UrlMatches(url));
            }
            catch (Exception)
            {
                string actualURL = driver.Url.ToString();

                throw new Exception("This url was opened ----- " + actualURL + " ----- But was expecting this URL ----- " + url);
            }
        }

        #endregion

        /// <summary>
        /// This is a polling method to wait for an Expected Condition and periodically check it and fail if time runs out
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public WebDriverWait Wait(int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(200)
            };
            return wait;
        }

        /// <summary>
        /// Gets the current page url and checks it against the expected URL
        /// </summary>
        /// <param name="expectedUrl"></param>
        public void CheckUrlOfPageIsCorrect(string expectedUrl, string actualUrl)
        {
            driver.Url.Should().Contain(expectedUrl);

            Assert.Equal(expectedUrl, actualUrl);
        }

        /// <summary>
        /// Check the Title against the actual title
        /// </summary>
        /// <param name="expectedTitle"></param>
        public void CheckTitleIsCorrectAsExpected(string expectedTitle)
        {
            driver.Title.Should().Contain(expectedTitle);
        }


        /// <summary>
        /// This validates one text against the expected text in the particular locator
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="expectedText"></param>
        public void CheckElementTextMatchesExpectedText(By selector, string expectedText)
        {
            RetryTimer(() =>
            {
                string valueText = "";

                try
                {
                    valueText = Text(selector);
                    valueText.Should().Contain(expectedText);
                }
                catch (Exception)
                {
                    throw new Exception("Failed to Find this text " + valueText + " in this Text - " + expectedText);
                }
            });
        }

        /// <summary>
        /// This is a wrapper retry function ..it will retry a function for the set amount of seconds then fail
        /// </summary>
        /// <param name="function"></param>
        public static void RetryTimer(Action function)
        {
            int seconds = 10;
            bool elementFound;
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            while (stopWatch.Elapsed < TimeSpan.FromSeconds(seconds))
            {
                try
                {
                    function();
                    elementFound = true;
                }
                catch (Exception)
                {
                    if (stopWatch.Elapsed <= TimeSpan.FromSeconds(seconds))
                        elementFound = false;
                    else
                        throw;
                }

                if (elementFound)
                    break;
            }
            stopWatch.Reset();
        }

        /// <summary>
        /// Get the text of the element matching the given selector.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public string Text(By selector)
        {
            try
            {
                Wait().Until(x => x.FindElement(selector).Text.Length > 0);
                string elementText = driver.FindElement(selector).Text;

                return elementText;
            }
            catch (Exception)
            {
                throw new Exception("Could not get the text of the this element " + selector);
            }
        }


        /// <summary>
        /// Click the button and validate the ID value is not same
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="buttonIDValue"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public TestBase ClickAndGetIDValue(By selector)
        {
            try
            {
                IWebElement buttonValue = driver.FindElement(selector);
                string buttonIDValue = buttonValue.GetAttribute("id");
                buttonValue.Click();

                buttonValue = driver.FindElement(selector);
                Assert.NotEqual(buttonValue.GetAttribute("id"), buttonIDValue);

            }
            catch (Exception e)
            {
                throw new Exception("Unable to Click element " + selector + " " + e.Message);
            }
            return this;
        }

        /// <summary>
        /// Click the button
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public TestBase Click(By selector)
        {
            try
            {
                IWebElement buttonValue = driver.FindElement(selector);
                buttonValue.Click();

            }
            catch (Exception e)
            {
                throw new Exception("Unable to Click element " + selector + " " + e.Message);
            }
            return this;
        }

        /// <summary>
        /// Get number values from a string sentence using regex method and compared both numbers are not same after refresh the page
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public TestBase GetNumberValuesAndCompared(By selector)
        {
            try
            {
                string answerValue = driver.FindElement(selector).GetAttribute("innerHTML");
                string pattern = @"Answer:\s(\d+)";
                Match matchesAtStart = Regex.Match(answerValue, pattern);
                string getnumberValuesAtFirstTime = matchesAtStart.Groups[1].Value;

                driver.Navigate().Refresh();

                string answerValueAfterRefresh = driver.FindElement(selector).GetAttribute("innerHTML");
                Match matchesAfterRefresh = Regex.Match(answerValueAfterRefresh, pattern);
                string getnumberValuesSecondTime = matchesAfterRefresh.Groups[1].Value;

                Assert.NotEqual(getnumberValuesAtFirstTime, getnumberValuesSecondTime);

            }
            catch (Exception e)
            {

                throw new Exception("The Answer values are same after refrsh the page too: " + selector + " " + e.Message);
            }

            return this;

        }
    }
}
