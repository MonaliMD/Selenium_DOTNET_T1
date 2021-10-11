using System.Threading;
using OpenQA.Selenium;

namespace Selenium_DOTNET_T1.Pages
{
    public class HomePage
    {
        private object driver;

        public void homePageActions(IWebDriver driver)
        {

          
            // select administration on menu bar
            IWebElement adminstrationText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationText.Click();

            // select time and meterial on list and click on it
            IWebElement selectTM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            selectTM.Click();

            Thread.Sleep(2000);
           
        }
    
    }
}
