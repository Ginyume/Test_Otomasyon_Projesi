using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using OpenQA.Selenium.Support.UI;

namespace Test_Otomasyon_Projesi.Pages
{
    public class LoginPages
    {
        public LoginPages()
        {
            PageFactory.InitElements(Collection.webDriver, this);
        }
       WebDriverWait wait= new WebDriverWait(Collection.webDriver,TimeSpan.FromSeconds(50));
        
        [FindsBy(How =How.XPath,Using = "//div/div/input")]
        public IWebElement GoogleSearchBar { get; set; }
        [FindsBy(How =How.XPath,Using = "//div[5]/center[1]/input[1]")]
        public IWebElement GoogleSearcButton { get;set; }
        public void NameSearchOnGoogle(string Name)
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div/div/input")));
            GoogleSearchBar.SendKeys(Name);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[5]/center[1]/input[1]")));
            GoogleSearcButton.Click();
        }
    }
}
