using NUnit.Framework;
using POMHomework.Pages;

namespace POMHomework.Tests
{
    [TestFixture]
    class RegistrationTests : BaseTest
    {
        private User _user;
        private RegistrationPage regPage;

        [SetUp]
        public void RegistrationSetUp()
        {
            regPage = new RegistrationPage(_driver);
            regPage.NavigateTo();

            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void RegisterWithoutPhone()
        {
            _user.Phone = "";
            regPage.SubmitEmail("slav.hadzhiev@gmail.com");
            regPage.FillOutForm(_user);
            regPage.AssertPhoneError();
        }

        [Test]
        public void RegisterWithoutFirstName()
        {
            _user.FirstName = "";
            regPage.SubmitEmail("slav.hadzhiev@gmail.com");
            regPage.FillOutForm(_user);
            regPage.AssertFirstNameError();
        }

        [Test]
        public void RegisterWithoutLastName()
        {
            _user.LastName = "";
            regPage.SubmitEmail("slav.hadzhiev@gmail.com");
            regPage.FillOutForm(_user);
            regPage.AssertLastNameError();
        }

        [Test]
        public void RegisterWithoutAddress()
        {
            _user.Address = "";
            regPage.SubmitEmail("slav.hadzhiev@gmail.com");
            regPage.FillOutForm(_user);
            regPage.AssertAddressError();
        }

        [Test]
        public void RegisterWithoutCity()
        {
            _user.City = "";
            regPage.SubmitEmail("slav.hadzhiev@gmail.com");
            regPage.FillOutForm(_user);
            regPage.AssertCityError();
        }
    }
}
