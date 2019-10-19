using System;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class SoftuniPage : BasePage
    {
        private IWebElement automationCourseLink => _driver.FindElement(By.LinkText("QA Automation - септември 2019"));

        private IWebElement coursesButton => _driver.FindElement(By.XPath("//span[contains(text(), 'Обучения')]"));

        public SoftuniPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            _driver.Url = "https://softuni.bg/";
        }

        internal AutomationCoursePage GoToAutomationCourse()
        {
            coursesButton.Click();
            automationCourseLink.Click();

            return new AutomationCoursePage(_driver);
        }
    }
}