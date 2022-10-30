using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BBC_Copyright_SpecFlow_Test_Project.Drivers
{
    public class BrowserDriver : IDisposable
    {
        private readonly IWebDriver _driver;

        public BrowserDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        public IWebDriver Current => _driver;

        public void Dispose()
        {
            Current.Quit();
        }
    }
}
