using MyFirstTest.PageObjects;
using MyFirstTest1.PageObjects;
using MyFirstTest1.Utility;
using NUnit.Framework;

namespace MyFirstTest1.Tests
{
    public abstract class TestBase
    {
             
        protected TestBase()
        {
            _selenium = new Selenium();
        }
        
        protected MainPage MainPage => _mainPage ?? (_mainPage = new MainPage(_selenium.Driver));
        protected SearchBlock SearchBlock => _searchBlock ?? (_searchBlock = new SearchBlock(_selenium.Driver));

        private MainPage _mainPage;
        private SearchBlock _searchBlock;

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {
            _selenium.CloseBrowser();
        }

        private readonly Selenium _selenium;
    }
}
