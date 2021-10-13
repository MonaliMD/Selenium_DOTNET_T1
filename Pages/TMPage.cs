using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium_DOTNET_T1.Pages
{
    public class TMPage
    {
  
        public void createTM(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // Select create new button and click on it
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Find type code text box and slect "Time" on the list
            IWebElement selectDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            selectDropDown.Click();

            IWebElement selectTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            selectTime.Click();


            // Find code text box and enter the code number
            IWebElement addCode = driver.FindElement(By.Id("Code"));
            addCode.SendKeys("September2021_M");

            // Select description text box and enter discription
            IWebElement addDescription = driver.FindElement(By.Id("Description"));
            addDescription.SendKeys("M_Description");

            // Select price per unit text box and enter price
            IWebElement addPriceTextBox1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            addPriceTextBox1.SendKeys("100");
            //IWebElement addPriceTextBox2 = driver.FindElement(By.XPath("//*[@id='Price']"));
            //addPriceTextBox2.SendKeys("12343434");

            // Select save button and click on it
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);
            // Go to last page of input list
            IWebElement selectLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            selectLastPage.Click();

            // Select the saved code
            //IWebElement codeCheck = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //Assertion
            //IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement newSelectTime = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assertions
            //Assert.That(newCode.Text == "September2021_M", "Actual Code and expected newCode do not match");
            //Assert.That(newSelectTime.Text == "T", "Actual SelectedTime and expected SelectedTime do not match");
            //Assert.That(newDescription.Text == "M_Description", "Actual Description and expected l newDescription do not match");
            //Assert.That(newPrice.Text == "$100.00", "Actual Price and expected newPrice do not match");

            //Check if saved suucessfully
            //if (codeCheck.Text == "September2021_M")
            //{
            //    Console.WriteLine("Saved suceesfully, test passed");
            //}
            //else
            //{
            //    Console.WriteLine("Not saved, test failed");
            //}
        }
        //Best practice for asserting
        public string getCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string getSelectTime(IWebDriver driver)
        {
            IWebElement newSelectTime = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newSelectTime.Text;
        }

        public string getDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;

        }
        public string getPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void editTM(IWebDriver driver, string p0, string p1)
        {
            // Go to the last page where new record created will be
            IWebElement selectLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            selectLastPage.Click();

            // Find final record created
            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "September2021_M")
            {
               
                // Select edit button and click it
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);

                // Click on "TypeCode" from dropdown list and set the Type Code
                IWebElement typeCodeDropdown1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                typeCodeDropdown1.Click();
                Thread.Sleep(2000);

                IWebElement selectMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                selectMaterial.Click();
                Thread.Sleep(2000);

                


                // Find the code text box clear and edit the code
                IWebElement addCode2 = driver.FindElement(By.Id("Code"));
                addCode2.Clear();
                addCode2.SendKeys(p0);

                //IWebElement addCodeEdit = driver.FindElement(By.Id("Code"));

                // Click on "Description" from Textbox and set the description
                IWebElement descriptionTextBox1 = driver.FindElement(By.Id("Description"));
                descriptionTextBox1.Clear();
                descriptionTextBox1.SendKeys(p1);
                Thread.Sleep(2000);

                // Click on "Price per unit" textbox and clear the price
                IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                priceTag.Click();
                Thread.Sleep(2000);

                IWebElement pricePerUnit1 = driver.FindElement(By.Id("Price"));
                pricePerUnit1.Clear();
                Thread.Sleep(2000);

                priceTag.Click();
                Thread.Sleep(2000);

                // IWebElement pricePerUnit2 = testDriver.FindElement(By.Id("Price"));
                pricePerUnit1.SendKeys("170.00");
                Thread.Sleep(2000);


                // Find the save button and click on it
                IWebElement saveAfterEdit = driver.FindElement(By.Id("SaveButton"));
                saveAfterEdit.Click();


                Thread.Sleep(2000);
                // Go to last page of input list
                IWebElement selectLastPage1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                selectLastPage1.Click();


                // Assertion
               // IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                //IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
                //Assert.That(newCode.Text == "September2021_M_Edit", "Actual Code and expected code do not match.");
                //Assert.That(newTypeCode.Text == "M", "Actual TypeCode and expected tyecode do not match.");
                //Assert.That(newDescription.Text == "Automated Script1 is changed", "Actual Description and expected description do not match.");
                //Assert.That(newPrice.Text == "$170.00", "Actual Price and expected price do not match.");
                // Find code after edited
                //IWebElement codeCheck1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            }
            else
            { 
                Assert.Fail("Record to be edited hasn't been found. Record not edited.");
            }

           


            Thread.Sleep(2000);
        }

        public string editCode(IWebDriver driver)
        {
            IWebElement editedNewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedNewCode.Text;
        }
        public string editTypeCode(IWebDriver driver)
        {
            IWebElement editedNewTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedNewTypeCode.Text;
        }
        public string editDescription(IWebDriver driver)
        {
            IWebElement editedNewDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedNewDescription.Text;
        }
        public string editPrice(IWebDriver driver)
        {
            IWebElement editedNewPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedNewPrice.Text;
        }

        public void deleteTM(IWebDriver driver)
        {
            //Go to last page
            IWebElement selectLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            selectLastPage.Click();

            //Find Edited Record
            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if(findEditedRecord.Text == "September2021_M_Edit")
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

            //Go to last page
            IWebElement selectLastPage1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            selectLastPage1.Click();

             // Assertion
             IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
             IWebElement editedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
             IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
             IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
             Assert.That(editedCode.Text != "September2021_M_Edit", "Code record hasn't been deleted.");
             Assert.That(editedTypeCode.Text != "M", "TypeCode record hasn't been deleted..");
             Assert.That(editedDescription.Text != "Automated Script1 is changed", "Description record hasn't been deleted.");
             Assert.That(editedPrice.Text != "$170.00", "Price record hasn't been deleted..");




                // Find code after edited
                IWebElement codeCheck2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }
            //Check if delete successfully
            //if (codeCheck2.Text != "September2021_M_Edit")
            //{
            //    Console.WriteLine("Delete suceesfully, test passed");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted, test failed");
            //}
        }
    }
}
