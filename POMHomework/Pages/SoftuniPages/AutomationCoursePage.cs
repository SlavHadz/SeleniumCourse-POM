using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class AutomationCoursePage : BasePage
    {
        private IWebElement headingElement => _driver.FindElement(By.XPath("//h1[contains(text(), 'QA Automation')]"));

        public AutomationCoursePage(IWebDriver driver):base(driver)
        {
        }

        public void AssertHeadingText()
        {
            Assert.IsTrue(headingElement.Displayed);
        }
    }
}