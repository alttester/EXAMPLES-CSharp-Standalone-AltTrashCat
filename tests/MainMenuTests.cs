using System;
using System.Threading;
using AltTester.AltTesterUnitySDK.Driver;
using alttrashcat_tests_csharp.pages;
using NUnit.Framework;
using NUnit.Allure.Core;
namespace alttrashcat_tests_csharp.tests
{
    [TestFixture]
    [AllureNUnit]
    public class MainMenuTests
    {
        AltDriver altDriver;
        MainMenuPage mainMenuPage;
        [SetUp]
        public void Setup()
        {
            altDriver = new AltDriver(port: 13000);
            mainMenuPage = new MainMenuPage(altDriver);
            mainMenuPage.LoadScene();
        }

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }

        [Test]
        public void TestMainMenuPageLoadedCorrectly()
        {
            Assert.True(mainMenuPage.IsDisplayed());
        }
    }
}