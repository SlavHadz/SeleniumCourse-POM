using System;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SignInLink => _driver.FindElement(By.LinkText("Sign in"));

        public void NavigateTo()
        {
            _driver.Url = "http://automationpractice.com/index.php";
        }

        internal SignInPage GoToRegistration()
        {
            SignInLink.Click();

            return new SignInPage(_driver);
        }
    }
}