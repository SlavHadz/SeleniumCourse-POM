using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement MobilePhoneInput => _driver.FindElement(By.Id("phone_mobile"));

        private IWebElement createButton => _driver.FindElement(By.Id("SubmitCreate"));

        private IWebElement emailInput => _driver.FindElement(By.Id("email_create"));

        public IWebElement RadioButton => _wait.Until(d => d.FindElement(By.Id("id_gender1")));

        public IWebElement FirstNameInput => _driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastNameInput => _driver.FindElement(By.Id("customer_lastname"));

        public IWebElement PasswordInput => _driver.FindElement(By.Id("passwd"));

        public SelectElement Days
        {
            get
            {
                IWebElement daysDropdown = _driver.FindElement(By.Id("days"));
                return new SelectElement(daysDropdown);
            }
        }

        public SelectElement Month
        {
            get
            {
                IWebElement monthDropdown = _driver.FindElement(By.Id("months"));
                return new SelectElement(monthDropdown);
            }
        }

        public SelectElement Year
        {
            get
            {
                IWebElement yearDropdown = _driver.FindElement(By.Id("years"));
                return new SelectElement(yearDropdown);
            }
        }

        public IWebElement Address => _driver.FindElement(By.Id("address1"));

        public IWebElement City => _driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement stateDropdown = _driver.FindElement(By.Id("id_state"));
                return new SelectElement(stateDropdown);
            }
        }

        public IWebElement ZipCodeInput => _driver.FindElement(By.Id("postcode"));

        public IWebElement RegisterButton => _driver.FindElement(By.Id("submitAccount"));

        public void NavigateTo()
        {
            _driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        }

        public void SubmitEmail(string email)
        {
            emailInput.SendKeys(email);
            createButton.Click();
        }

        internal void FillOutForm(User user)
        {
            RadioButton.Click();
            FirstNameInput.SendKeys(user.FirstName);
            LastNameInput.SendKeys(user.LastName);
            PasswordInput.SendKeys(user.Password);
            Days.SelectByValue(user.Date);
            Month.SelectByValue(user.Month);
            Year.SelectByValue(user.Year);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            ZipCodeInput.SendKeys(user.PostCode);
            MobilePhoneInput.SendKeys(user.Phone);
            RegisterButton.Click();
        }

        internal void AssertFirstNameError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='alert alert-danger']//b[contains(text(), 'firstname')]")).Displayed);
        }

        internal void AssertAddressError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='alert alert-danger']//b[contains(text(), 'address1')]")).Displayed);
        }

        internal void AssertCityError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='alert alert-danger']//b[contains(text(), 'city')]")).Displayed);
        }

        internal void AssertLastNameError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='alert alert-danger']//b[contains(text(), 'lastname')]")).Displayed);
        }

        internal void AssertPhoneError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li[contains(text(), 'You must register')]")).Displayed);
        }
    }
}
