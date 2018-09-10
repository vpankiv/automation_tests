using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstTest1.Utility
{
    class Selenium
    {
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    InitBrowser();
                }
                return _driver;
            }
        }

        public void CloseBrowser()
        {
            if (_driver == null) return;

            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }

        private void InitBrowser()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, GetChromeOptions());

        }

        private ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-extentions");
            options.AddArgument("--disable-infobars");
            return options;
        }
        
        private IWebDriver _driver;
    }
}
