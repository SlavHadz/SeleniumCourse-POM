using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class GoogleResultsPage
    {
        private IWebDriver _driver;

        private IWebElement firstLink => _driver.FindElement(By.XPath("//h3[contains(text(), 'Selenium - Web Browser Automation')]"));

        public GoogleResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal SeleniumPage ClickFirstLink()
        {
            firstLink.Click();

            return new SeleniumPage(_driver);
        }
    }
}