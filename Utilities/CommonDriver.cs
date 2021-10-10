using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_DOTNET_T1.Pages;

namespace Selenium_DOTNET_T1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        //open chrome browser
        
        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();
            //Home page actions
            HomePage homepageObj = new HomePage();
            homepageObj.homePageActions(driver);

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
