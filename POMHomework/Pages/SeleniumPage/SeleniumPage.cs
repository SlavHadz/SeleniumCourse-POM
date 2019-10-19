using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class SeleniumPage
    {
        private IWebDriver _driver;

        public SeleniumPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void AssertTitle()
        {
            Assert.AreEqual("Selenium - Web Browser Automation", _driver.Title);
        }
    }
}