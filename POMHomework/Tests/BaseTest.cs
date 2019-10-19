using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace POMHomework
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver _driver;

        [SetUp]
        public void TestInitialize()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            //var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //_driver = new ChromeDriver(path);

            _driver = new RemoteWebDriver(new Uri("http://192.168.0.102:24006/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
