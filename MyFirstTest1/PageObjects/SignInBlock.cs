using MyFirstTest1.PageObjects;
using OpenQA.Selenium;

namespace MyFirstTest.PageObjects
{
    public class SignInBlock : PageBase
    {
        public SignInBlock(IWebDriver driver) : base(driver)
        {
        }

        public void SignIn(string email, string password)
        {
            Driver.FindElement(_emailLocator).SendKeys(email);
            Driver.FindElement(_passwordLocator).SendKeys(password);
            Driver.FindElement(_signInButtonlLocator).Click();
        }

        private readonly By _emailLocator = By.Id("email");
        private readonly By _passwordLocator = By.Id("passwd");
        private readonly By _signInButtonlLocator = By.Id("SubmitLogin");
    }
}
