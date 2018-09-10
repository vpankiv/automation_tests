using MyFirstTest1.PageObjects;
using OpenQA.Selenium;
using System;

namespace MyFirstTest.PageObjects
{
    public class SearchBlock : PageBase
    {
        public SearchBlock(IWebDriver driver) : base(driver)
        {
        }
        
        public SearchBlock OpenSearchBlock(string criteria)
        {
            Driver.FindElement(_searchBoxLocator).SendKeys(criteria);
            Driver.FindElement(_searchButtonlLocator).Click();
            return this;
        }
        public SearchBlock AddItem()
        {
            Driver.FindElement(_itemLocator).Click();
            Driver.FindElement(_addButtonLocator).Click();
            return this;
        }
        public void Checkout()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.FindElement(_proceedButtonLocator).Click();
            Driver.FindElement(_summaryProceedButtonLocator).Click();
            Driver.FindElement(_summaryProceedButtonLocator).Click();
            Driver.FindElement(_checkBoxLocator).Click();
            Driver.FindElement(_submitButtonLocator).Click();
            Driver.FindElement(_payModeLocator).Click();
            Driver.FindElement(_confirmButtonLocator).Click();
        }
        protected readonly By _searchBoxLocator = By.Id("search_query_top");
        protected readonly By _searchButtonlLocator = By.Name("submit_search");
        protected readonly By _itemLocator = By.XPath("//a[@class='product-name' and @title='Faded Short Sleeve T-shirts']");
        protected readonly By _addButtonLocator = By.XPath("//button//span[text()= 'Add to cart']");
        protected readonly By _proceedButtonLocator = By.XPath("//div[@id='layer_cart' and contains(@style,'block')]//span[contains(text(), 'Proceed to checkout')]");
        protected readonly By _summaryProceedButtonLocator = By.XPath("//div[@id='center_column']//span[contains(text(), 'Proceed to checkout')]");
        protected readonly By _checkBoxLocator = By.Id("cgv");
        protected readonly By _submitButtonLocator = By.XPath("//button//span[contains(text(), 'Proceed to checkout')]");
        protected readonly By _payModeLocator = By.XPath("//a[@class='bankwire']");
        protected readonly By _confirmButtonLocator = By.XPath("//button[@class='button btn btn-default button-medium']");
    }
}
