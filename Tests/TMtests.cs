
using NUnit.Framework;
using Selenium_DOTNET_T1.Pages;
using Selenium_DOTNET_T1.Utilities;

namespace Selenium_DOTNET_T1
{
    [TestFixture]
    //[Parallelizable]
    public class TMtests : CommonDriver
    {
        [Test , Order(1), Description ("Check if user able to create new time & material with valid data")]
        public void CreateTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.homePageActions(driver);
                                                                
            //Time and Material page create actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.createTM(driver);
        }

        [Test, Order(2), Description ("Check user able to edit Time or Material with valid data")]
        public void EditTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.homePageActions(driver);

            //Time and Material page edit actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.editTM(driver, "dummy", "dummy");
        }

        [Test, Order(3), Description ("Check user able to delete time or material records")]
        public void DeleteTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.homePageActions(driver);

            //Time and Material page delete actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.deleteTM(driver);
        }
    }
}
