using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class SignInPage : BasePage
    {
        private IWebElement authHeading => _driver.FindElement(By.XPath("//h1[contains(text(), 'Authentication')]"));

        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        internal void AssertOpened()
        {
            Assert.IsTrue(authHeading.Displayed);
        }
    }
}