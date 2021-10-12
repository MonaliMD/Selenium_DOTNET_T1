using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium_DOTNET_T1.Pages;
using Selenium_DOTNET_T1.Utilities;
using TechTalk.SpecFlow;

namespace Selenium_DOTNET_T1.SpecDefinition
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {

        // Page object initialization
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageOjb = new HomePage();
        TMPage tmPageOjb = new TMPage();

        [Given(@"I logged in to turnup prtal successfully")]
        public void GivenILoggedInToTurnupPrtalSuccessfully()
        {
            //open chrome browser
            driver = new ChromeDriver();

            //Login Actions definition
            loginPageObj.loginActions(driver);
        }
        
        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            //Home page object definition
            homePageOjb.homePageActions(driver);
        }
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            //TMe page object definition
            tmPageOjb.createTM(driver);
        }
        
        [Then(@"Then the record shoul be create successfully")]
        public void ThenThenTheRecordShoulBeCreateSuccessfully()
        {
            string newCode = tmPageOjb.getCode(driver);
            string newSelectTime = tmPageOjb.getSelectTime(driver);
            string newDescription = tmPageOjb.getDescription(driver);
            string getPrice = tmPageOjb.getPrice(driver);

            Assert.That(newCode == "eptember2021_M", "Code did not match");
        }
    }
}
