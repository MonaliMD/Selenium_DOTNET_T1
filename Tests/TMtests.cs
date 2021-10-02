using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_DOTNET_T1.Pages;

namespace Selenium_DOTNET_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();


            //Home page actions
            HomePage homepageObj = new HomePage();
            homepageObj.homePageActions(driver);

            //Login Actions
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginActions(driver);
          
            //Time and Material page create actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.createTM(driver);

            //Time and Material page edit actions
            tmPageObj.editTM(driver);

            //Time and Material page delete actions
            tmPageObj.deleteTM(driver);
        }
    }
}
