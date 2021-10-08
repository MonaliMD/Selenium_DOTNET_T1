using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_DOTNET_T1.Utilities
{
    class Wait
    {
        public void waitForElementToBeClickable(IWebDriver driver, string locaterType, string locaterValue, int seconds )
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locaterValue)));

        }
    }
}
