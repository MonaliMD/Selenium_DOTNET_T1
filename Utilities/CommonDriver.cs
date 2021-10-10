using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_DOTNET_T1.Pages;

namespace Selenium_DOTNET_T1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        
        
        [OneTimeSetUp]
        public void LoginActions()
        {
            //open chrome browser
            driver = new ChromeDriver();


            //Login Actions
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginActions(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
