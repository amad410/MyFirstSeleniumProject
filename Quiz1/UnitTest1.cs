using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Quiz1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //using the . operator to get webdriver properties
            var pageSource = driver.PageSource;
            var title = driver.Title;
            var url = driver.Url;

        }
        [TestMethod]
        public void TestMethod2()
        {
            //clicking on an element
            driver.Navigate().GoToUrl("http://tailspintoys.azurewebsites.net/");
            IWebElement modelAirplaneLinkMenu = driver.FindElement(By.LinkText("Model Airplanes"));
            modelAirplaneLinkMenu.Click();

        }

        [TestInitialize]
        public void Setup()
        {
            //Method for performing a precondition

            //driver object
            driver = new ChromeDriver();

            //using the '.' operator to view additional methods and properties of the driver object
            driver.Manage().Window.Maximize();
            

        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
