using NUnit.Framework;
using MyFirstTest1.PageObjects;

namespace MyFirstTest1.Tests
{
    [TestFixture]

    public class LoginTests : TestBase
    {
        [Test]

        public void PositiveTest()
        {
            MainPage.Navigate();
            MainPage.SignIn("vitalii.pankiv@gmail.com", "method");
            Assert.That(MainPage.GetUserName(), Is.EqualTo("Vitalii Pankiv"));

        }

        [Test]

        public void NegativeTest()
        {
            MainPage.Navigate();
            MainPage.SignIn("negative@gmail.com", "method");
            Assert.That(MainPage.GetErrorMessage(), Is.EqualTo("Authentication failed."));

        }
    }
}
