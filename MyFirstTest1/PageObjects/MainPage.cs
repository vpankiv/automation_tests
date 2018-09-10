using OpenQA.Selenium;
using MyFirstTest.PageObjects;
using MyFirstTest1.Utility;
using NUnit.Framework;

namespace MyFirstTest1.PageObjects
{
    public class MainPage : PageBase
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        public void SignIn(string email, string password)
        {
            Driver.FindElement(_signInButtonLocator).Click();
            new SignInBlock(Driver).SignIn(email, password);
        }
                   
        public string GetUserName()
        {
            IWebElement account = Driver.FindElement(_accountLocator);
            string text = account.Text;
            return text;
        }

        public string GetErrorMessage()
        {
            return Driver.FindElement(_errorMessageLocator).Text;
        }
        
        public string GetCompleteOrderMessage()
        {
            return Driver.FindElement(_confirmationMessageLocator).Text;
        }

        private readonly By _signInButtonLocator = By.XPath("//a[contains(text(), 'Sign in')]");
        private readonly By _accountLocator = By.XPath("//a[@class='account']");
        private readonly By _errorMessageLocator = By.XPath("//*[@class='alert alert-danger']//li");        
        protected readonly By _confirmationMessageLocator = By.XPath("//p/strong[@class='dark']");
    }
}
