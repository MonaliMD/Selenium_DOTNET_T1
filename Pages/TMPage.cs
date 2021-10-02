using System;
using System.Threading;
using OpenQA.Selenium;

namespace Selenium_DOTNET_T1.Pages
{
    public class TMPage
    {
        //private object driver;


        

        public void createTM(IWebDriver driver)
        {
            // Find code text box and enter the code number
            IWebElement addCode = driver.FindElement(By.Id("Code"));
            addCode.SendKeys("Monali123");

            // Select description text box and enter discription
            IWebElement addDescription = driver.FindElement(By.Id("Description"));
            addDescription.SendKeys("Monali123");

            // Select price per unit text box and enter price
            IWebElement addPriceTextBox1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            addPriceTextBox1.SendKeys("12343434");
            //IWebElement addPriceTextBox2 = driver.FindElement(By.XPath("///*[@id='Price']"));
            //addPriceTextBox2.SendKeys("12343434");

            // Select save button and click on it
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);
            // Go to last page of input list
            IWebElement selectLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            selectLastPage.Click();

            // Select the saved code
            IWebElement codeCheck = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            //Check if saved suucessfully
            if (codeCheck.Text == "Monali123")
            {
                Console.WriteLine("Saved suceesfully, test passed");
            }
            else
            {
                Console.WriteLine("Not saved, test failed");
            }

        }

        public void editTM(IWebDriver driver)
        {
            // Check can edit successfully

            // Select edit button and click it
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();


            // Clear
            IWebElement addCode2 = driver.FindElement(By.Id("Code"));
            addCode2.Clear();

            // Find the code text box and edit the code
            //IWebElement addCodeEdit = driver.FindElement(By.Id("Code"));
            addCode2.SendKeys("Monali1234");

            // Find the save button and click on it
            IWebElement saveAfterEdit = driver.FindElement(By.Id("SaveButton"));
            saveAfterEdit.Click();


            Thread.Sleep(2000);
            // Go to last page of input list
            IWebElement selectLastPageAfterEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            selectLastPageAfterEdit.Click();

            // Find code after edited
            IWebElement codeCheck1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            //Check if edit suucessfully
            if (codeCheck1.Text == "Monali1234")
            {
                Console.WriteLine("Edit suceesfully, test passed");
            }
            else
            {
                Console.WriteLine("Not edited, test failed");
            }

            Thread.Sleep(2000);
        }
        public void deleteTM(IWebDriver driver)
        {
            //Check delete functionality
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //Select popup window
            //IWebElement popupWindow = driver.FindElement()
            var alert = driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alert.Accept();

            Thread.Sleep(2000);
            // Go to last page of input list
            //IWebElement selectLastPageAfterDelete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            //selectLastPageAfterDelete.Click();

            // Find code after edited
            IWebElement codeCheck2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //Check if delete successfully
            if (codeCheck2.Text != "Monali1234")
            {
                Console.WriteLine("Delete suceesfully, test passed");
            }
            else
            {
                Console.WriteLine("Not Deleted, test failed");
            }
        }
    }
}
