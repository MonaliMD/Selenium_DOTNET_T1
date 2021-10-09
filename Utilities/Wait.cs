using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_DOTNET_T1.Utilities
{
    class Wait
    {
        public static void waitForElementToBeClickable(IWebDriver driver, string locaterType, string locaterValue, int seconds )
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if(locaterType== "Xpath")
            { 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locaterValue)));
            }

            if (locaterType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locaterValue)));
            }
            if (locaterType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locaterValue)));
            }
        }
    }
}
