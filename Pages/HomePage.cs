using System.Threading;
using OpenQA.Selenium;
using Selenium_DOTNET_T1.Utilities;

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
            Wait.waitForElementToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]", 3);
           

            // select time and meterial on list and click on it
            IWebElement selectTM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            selectTM.Click();
            

            //Thread.Sleep(2000);
            // Select create new button and click on it
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Find type code text box and slect "Time" on the list
            IWebElement selectDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));

            IWebElement selectTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            selectTime.Click();
        }
    
    }
}
