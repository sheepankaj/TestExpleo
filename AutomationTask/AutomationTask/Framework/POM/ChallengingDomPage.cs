using AutomationTask.Framework.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationTask.Framework.POM
{
    public class ChallengingDomPage
    {
        #region Page Driver setup
        /// <summary>
        /// Giving the driver to the class
        /// </summary>
        private readonly TestBase TryTo;

        #region Page Locators values

        /// <summary>
        /// Header & Description locator value
        /// </summary>
        public static By ChallengingDom => By.Id("content");

        /// <summary>
        /// Actual URL link
        /// </summary>
        public string  ActualURL => "https://the-internet.herokuapp.com/challenging_dom";

        /// <summary>
        /// Edit URL link
        /// </summary>
        public string  ActualEditURL => "https://the-internet.herokuapp.com/challenging_dom#edit";

        /// <summary>
        /// Delete URL link
        /// </summary>
        public string  ActualDeleteURL => "https://the-internet.herokuapp.com/challenging_dom#delete";

        #endregion

        /// <summary>
        /// Open the https://the-internet.herokuapp.com/challenging_dom website
        /// </summary>  
        /// <param name="test"></param>
        /// <param name="startingPage"></param>
        public ChallengingDomPage(TestBase test, bool startingPage = false)
        {
            TryTo = test;
            if (startingPage)
            {
                test.VisitUrl(ActualURL);
            }

        }
        #endregion

        /// <summary>
        /// Check the Url and title is correct
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckUrlAndTitle()
        {
            TryTo.CheckUrlOfPageIsCorrect("https://the-internet.herokuapp.com/challenging_dom", ActualURL);
            TryTo.CheckTitleIsCorrectAsExpected("The Internet");

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Check the Title header and description text values are correct
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckTitleHeaderAndDescription()
        {
            TryTo.CheckElementTextMatchesExpectedText(ChallengingDom, "Challenging DOM");
            TryTo.CheckElementTextMatchesExpectedText(ChallengingDom, "The hardest part in automated web testing is finding the best locators (e.g., ones that well named, unique, and unlikely to change). It's more often than not that the application you're testing was not built with this concept in mind. This example demonstrates that with unique IDs, a table with no helpful locators, and a canvas element.");

            return new ChallengingDomPage(TryTo);
        }


        /// <summary>
        /// Verify the static header text values of the table as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticTableHeaderTexts()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[1]"), "Lorem");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[2]"), "Ipsum");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[3]"), "Dolor");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[4]"), "Sit");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[5]"), "Amet");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[6]"), "Diceret");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/thead/tr/th[7]"), "Action");


            return new ChallengingDomPage(TryTo);
        }


        /// <summary>
        /// Verify the static text values of the Lorem column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticLoremColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[1]"), "Iuvaret0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[1]"), "Iuvaret1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[1]"), "Iuvaret2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[1]"), "Iuvaret3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[1]"), "Iuvaret4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[1]"), "Iuvaret5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[1]"), "Iuvaret6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[1]"), "Iuvaret7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[1]"), "Iuvaret8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[1]"), "Iuvaret9");


            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Verify the static text values of the Ipsum column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticIpsumColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[2]"), "Apeirian0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[2]"), "Apeirian1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[2]"), "Apeirian2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[2]"), "Apeirian3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[2]"), "Apeirian4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[2]"), "Apeirian5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[2]"), "Apeirian6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[2]"), "Apeirian7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[2]"), "Apeirian8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[2]"), "Apeirian9");
            

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Verify the static text values of the Dolor column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticDolorColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[3]"), "Adipisci0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[3]"), "Adipisci1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[3]"), "Adipisci2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[3]"), "Adipisci3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[3]"), "Adipisci4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[3]"), "Adipisci5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[3]"), "Adipisci6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[3]"), "Adipisci7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[3]"), "Adipisci8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[3]"), "Adipisci9");


            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Verify the static text values of the Sit column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticSitColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[4]"), "Definiebas0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[4]"), "Definiebas1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[4]"), "Definiebas2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[4]"), "Definiebas3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[4]"), "Definiebas4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[4]"), "Definiebas5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[4]"), "Definiebas6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[4]"), "Definiebas7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[4]"), "Definiebas8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[4]"), "Definiebas9");


            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Verify the static text values of the Amet column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticAmetColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[5]"), "Consequuntur0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[5]"), "Consequuntur1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[5]"), "Consequuntur2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[5]"), "Consequuntur3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[5]"), "Consequuntur4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[5]"), "Consequuntur5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[5]"), "Consequuntur6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[5]"), "Consequuntur7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[5]"), "Consequuntur8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[5]"), "Consequuntur9");
            

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Verify the static text values of the Diceret column as expected
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage CheckStaticDiceretColumnTexValues()
        {
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[6]"), "Phaedrum0");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[2]/td[6]"), "Phaedrum1");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[3]/td[6]"), "Phaedrum2");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[4]/td[6]"), "Phaedrum3");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[5]/td[6]"), "Phaedrum4");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[6]/td[6]"), "Phaedrum5");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[7]/td[6]"), "Phaedrum6");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[8]/td[6]"), "Phaedrum7");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[9]/td[6]"), "Phaedrum8");
            TryTo.CheckElementTextMatchesExpectedText(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[6]"), "Phaedrum9");
           

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the blue button and validate the locator's ID value is changing after each click
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickBlueButtonAndCheckIDNotSameAfterEachClick()
        {
            TryTo.ClickAndGetIDValue(By.XPath("//div[@class=\"large-2 columns\"]/a[@class=\"button\"]"));

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the red button and validate the locator's ID value is changing after each click
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickRedButtonAndCheckIDNotSameAfterEachClick()
        {
            TryTo.ClickAndGetIDValue(By.XPath("//div[@class=\"large-2 columns\"]/a[@class=\"button alert\"]"));

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the green button and validate the locator's ID value is changing after each click
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickGreenButtonAndCheckIDNotSameAfterEachClick()
        {
            TryTo.ClickAndGetIDValue(By.XPath("//div[@class=\"large-2 columns\"]/a[@class=\"button success\"]"));

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Get the Answer value and compare to see the old and new answer value are same
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage GetTheAnswerValueAndRefreshPageToSeeNewAnswerValueNotSame()
        {
            TryTo.GetNumberValuesAndCompared(By.XPath("//div[@id=\"content\"]/script"));

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the edit button at the 1st row and chekc the URL is updated with edit text
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickFirstRowEditButtonAndCheckTheURLwithEditText()
        {
            TryTo.Click(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[7]/a[1]"));
            TryTo.CheckUrlOfPageIsCorrect("https://the-internet.herokuapp.com/challenging_dom#edit",ActualEditURL);

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the delete button at the 1st row and chekc the URL is updated with delete text
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickFirstRowDeleteButtonAndCheckTheUrlWithDeleteText()
        {
            TryTo.Click(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[1]/td[7]/a[2]"));
            TryTo.CheckUrlOfPageIsCorrect("https://the-internet.herokuapp.com/challenging_dom#delete", ActualDeleteURL);

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the edit button at the last row and chekc the URL is updated with edit text
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickLastRowEditButtonAndCheckTheURLwithEditText()
        {
            TryTo.Click(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[7]/a[1]"));
            TryTo.CheckUrlOfPageIsCorrect("https://the-internet.herokuapp.com/challenging_dom#edit", ActualEditURL);

            return new ChallengingDomPage(TryTo);
        }

        /// <summary>
        /// Click the delete button at the last row and chekc the URL is updated with delete text
        /// </summary>
        /// <returns></returns>
        public ChallengingDomPage ClickLastRowDeleteButtonAndCheckTheUrlWithDeleteText()
        {
            TryTo.Click(By.XPath("//*[@id=\"content\"]//div[2]/table/tbody/tr[10]/td[7]/a[2]"));
            TryTo.CheckUrlOfPageIsCorrect("https://the-internet.herokuapp.com/challenging_dom#delete", ActualDeleteURL);

            return new ChallengingDomPage(TryTo);
        }
    }
}
