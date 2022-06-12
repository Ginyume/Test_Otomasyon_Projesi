using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Otomasyon_Projesi.Pages;
using System.Threading;

namespace Test_Otomasyon_Projesi.Tests
{
    [TestClass]
    public class Tests
    {

        [TestInitialize]
        public void Startup()
        {
            Collection.webDriver = new ChromeDriver();
            Collection.webDriver.Manage().Window.Maximize();
            Collection.webDriver.Navigate().GoToUrl(Collection.URL);
        }
        [TestMethod]
        public void GotoName()
        {
            LoginPages loginPages = new LoginPages();
            loginPages.NameSearchOnGoogle("Hamza AKINCI");
        }
        [TestCleanup]
        public void TearDown()
        {
            Collection.webDriver.Quit();
        }
    }
}

