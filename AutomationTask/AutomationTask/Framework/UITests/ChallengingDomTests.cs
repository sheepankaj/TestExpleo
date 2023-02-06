using AutomationTask.Framework.Common;
using AutomationTask.Framework.POM;
using Xunit;

namespace AutomationTask.Framework.UITests
{
    [Collection("Challenging Dom tests suite having test cases")]
    public class ChallengingDomTests : TestBase
    {
        /// <summary>
        /// Validate the Url title and header description values
        /// </summary>
        [Fact]
        public void ValidateURLTitleAndHeaderDescriptionValues()
        {
            new ChallengingDomPage(this, true)
                .CheckUrlAndTitle()
                .CheckTitleHeaderAndDescription();
        }

        /// <summary>
        /// Validate all header texts of the table
        /// </summary>
        [Fact]
        public void ValidateStaticHeaderTextValuesOfTheTable()
        {
            new ChallengingDomPage(this, true)
                .CheckStaticTableHeaderTexts();
        }

        /// <summary>
        /// Validate all text values for columns of the table
        /// </summary>
        [Fact]
        public void ValidateStaticTextValuesOfAllColumns()
        {
            new ChallengingDomPage(this, true)
                .CheckStaticLoremColumnTexValues()
                .CheckStaticIpsumColumnTexValues()
                .CheckStaticDolorColumnTexValues()
                .CheckStaticSitColumnTexValues()
                .CheckStaticAmetColumnTexValues()
                .CheckStaticDiceretColumnTexValues();
        }

        /// <summary>
        /// Validate Blue button ID value changes after each click
        /// </summary>
        [Fact]
        public void ValidateBlueButton()
        {
            new ChallengingDomPage(this, true)
                .ClickBlueButtonAndCheckIDNotSameAfterEachClick();
        }

        /// <summary>
        /// Validate Red button ID value changes after each click
        /// </summary>
        [Fact]
        public void ValidateRedButton()
        {
            new ChallengingDomPage(this, true)
                .ClickRedButtonAndCheckIDNotSameAfterEachClick();
        }

        /// <summary>
        /// Validate Green button ID value changes after each click
        /// </summary>
        [Fact]
        public void ValidateGreenButton()
        {
            new ChallengingDomPage(this, true)
                .ClickGreenButtonAndCheckIDNotSameAfterEachClick();
        }

        /// <summary>
        /// Validate Answer value changes after each click
        /// </summary>
        [Fact]
        public void ValidateAnswerValueChangesAfterRefreshingThePageEachTime()
        {
            new ChallengingDomPage(this, true)
                .GetTheAnswerValueAndRefreshPageToSeeNewAnswerValueNotSame();
        }

        /// <summary>
        /// Validate Url link updated wth edit text after clicking the 1st row edit button
        /// </summary>
        [Fact]
        public void ValidateAfterClickingFirstRowEditButtonTheUrlUpdatedWithEditText()
        {
            new ChallengingDomPage(this, true)
                .ClickFirstRowEditButtonAndCheckTheURLwithEditText();
        }

        /// <summary>
        /// Validate Url link updated wth delete text after clicking the 1st row delete button
        /// </summary>
        [Fact]
        public void ValidateAfterClickingFirstRowDeleteButtonTheUrlUpdatedWithEditText()
        {
            new ChallengingDomPage(this, true)
                .ClickFirstRowDeleteButtonAndCheckTheUrlWithDeleteText();
        }

        /// <summary>
        /// Validate Url link updated wth edit text after clicking the last row edit button
        /// </summary>
        [Fact]
        public void ValidateAfterClickingLastRowEditButtonTheUrlUpdatedWithEditText()
        {
            new ChallengingDomPage(this, true)
                .ClickLastRowEditButtonAndCheckTheURLwithEditText();
        }

        /// <summary>
        /// Validate Url link updated wth delete text after clicking the last row delete button
        /// </summary>
        [Fact]
        public void ValidateAfterClickingLastRowDeleteButtonTheUrlUpdatedWithEditText()
        {
            new ChallengingDomPage(this, true)
                .ClickLastRowDeleteButtonAndCheckTheUrlWithDeleteText();
        }
    }
}
