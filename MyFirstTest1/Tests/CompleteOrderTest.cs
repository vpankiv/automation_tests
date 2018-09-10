using MyFirstTest.PageObjects;
using MyFirstTest1.Tests;
using NUnit.Framework;

namespace OrderTest.Tests
{
    [TestFixture]

    public class OrderTests : TestBase
    {
        [Test]
        public void MainTest()
        {
            MainPage.Navigate();
            MainPage.SignIn("vitalii.pankiv@gmail.com", "method");
            SearchBlock
                .OpenSearchBlock("Sleeve")
                .AddItem()
                .Checkout();
            Assert.That(MainPage.GetCompleteOrderMessage(), Is.EqualTo("Your order on My Store is complete."));
        }

    }
}
