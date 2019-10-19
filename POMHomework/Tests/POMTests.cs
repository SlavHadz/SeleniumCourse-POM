using NUnit.Framework;

namespace POMHomework
{
    [TestFixture]
    public class POMTests : BaseTest
    {
        [Test]
        public void GoogleSearchTest()
        {
            GooglePage googlePage = new GooglePage(_driver);
            googlePage.NavigateTo();
            GoogleResultsPage googleResultsPage = googlePage.Search("Selenium - Web Browser Automation");
            SeleniumPage seleniumPage = googleResultsPage.ClickFirstLink();
            seleniumPage.AssertTitle();
        }

        [Test]
        public void AutomationCoursePageTest()
        {
            SoftuniPage softuniPage = new SoftuniPage(_driver);
            softuniPage.NavigateTo();
            AutomationCoursePage automationCoursePage = softuniPage.GoToAutomationCourse();
            automationCoursePage.AssertHeadingText();
        }

        [Test]
        public void OpenRegistrationPageTest()
        {
            AutomationPracticePage apPage = new AutomationPracticePage(_driver);
            apPage.NavigateTo();
            SignInPage signInPage = apPage.GoToRegistration();
            signInPage.AssertOpened();
        }

    }
}
