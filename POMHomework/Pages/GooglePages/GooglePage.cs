using System;
using OpenQA.Selenium;

namespace POMHomework
{
    internal class GooglePage : BasePage
    {
        private IWebElement searchInput => _driver.FindElement(By.ClassName("gLFyf"));

        public GooglePage(IWebDriver driver):base(driver)
        {
        }

        internal void NavigateTo()
        {
            _driver.Url = "https://www.google.com/";
        }

        internal GoogleResultsPage Search(string searchText)
        {
            searchInput.SendKeys("Selenium - Web Browser Automation");
            searchInput.SendKeys(Keys.Return);
            return new GoogleResultsPage(_driver);
        }
    }
}