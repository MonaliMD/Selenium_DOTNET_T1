
using NUnit.Framework;
using Selenium_DOTNET_T1.Pages;
using Selenium_DOTNET_T1.Utilities;

namespace Selenium_DOTNET_T1
{
    [TestFixture]
    public class TMtests : CommonDriver
    {
        [Test]
        public void CreateTMTest()
        {
            //Time and Material page create actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.createTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            //Time and Material page edit actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.editTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            //Time and Material page delete actions
            TMPage tmPageObj = new TMPage();
            tmPageObj.deleteTM(driver);
        }
    }
}
