using OpenQA.Selenium;

namespace MyFirstTest1.PageObjects
{
    public abstract class PageBase
    {
        protected PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver;
        
    }
}
