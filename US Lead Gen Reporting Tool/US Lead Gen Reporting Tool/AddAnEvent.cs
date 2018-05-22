using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;



namespace US_Lead_Gen_Reporting_Tool
{
    [TestClass]
    public class AddAnEvent
    {
        [TestMethod]
        public void Use_This_Test_To_Add_An_Event()
        {
            using (var driver = new ChromeDriver())
            {


                // Maximize Browser Window
                driver.Manage().Window.Maximize();

                // Navigate to url 
                driver.Navigate().GoToUrl("https://us-dev.gmli2.bluewatertech.host");

                // Find SignIn btn and Click
                driver.FindElementByXPath("//*[@id='NavigationMenu']/li").Click();

                // Thread.Sleep() used to delay the driver to allow the web page to load.
                //Thread.Sleep(2000);

                driver.FindElementByName("Email").SendKeys("jwaryas@bluewatertech.com");

                driver.FindElementByName("Password").SendKeys("Droop420!");

                Thread.Sleep(200);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                //This is for mouseover actions.
                Actions builder = new Actions(driver);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(4000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/div/ul/li[5]/span")).Perform();

                Thread.Sleep(2000);

                //Selects the Source Codes Button in the system dropdown 
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(2)").Click();

                Thread.Sleep(1000);

                //Selects the Add new source code button
                driver.FindElementByXPath("//*[@id='_gSourceCodes']/div[1]/a").Click();

                Thread.Sleep(1000);

                //Opens the dropdown for the brand you are selecting
                driver.FindElementByCssSelector("#BrandId").Click();

                Thread.Sleep(3000);

                //Selects the brand Buick
                driver.FindElementByCssSelector("#BrandId > option:nth-child(4)").Click();

                Thread.Sleep(2000);

                //Opens the Events Dropdown
                driver.FindElementByXPath("//*[@id='EventId']").Click();

                Thread.Sleep(2000);

                //Selects the "Bluewater Technologies Test Event" event
                driver.FindElementByCssSelector("#EventId > option:nth-child(8)").Click();

                //Selects the Handheld Check Box
                driver.FindElementByCssSelector("#IsHandheld").Click();

                //Selects VPP Check Box
                driver.FindElementByCssSelector("#VPPEnabled").Click();

                //Selects Loyalty Check Box
                driver.FindElementByCssSelector("#LoyaltyEnabled").Click();

                //Select The Multibrand Check Box
                driver.FindElementByCssSelector("#MultiBrandEnabled").Click();

                //Sets the soruce code text
                driver.FindElementByXPath("//*[@id='Code']").Click();

                driver.FindElementByXPath("//*[@id='Code']").SendKeys("Selenium01");

                //sets the date for the event being created
                // This will be used for the start date
                DateTime y = DateTime.Today.Date;

                //This will be used for the end date
                DateTime x = y.AddDays(5);
                
                //Source Code Start Date
                driver.FindElementByXPath("//*[@id='StartDate']").SendKeys(y.ToString("MM/dd/yyyy"));

                //Source Code End Date
                driver.FindElementByXPath("//*[@id='EndDate']").SendKeys(x.ToString("MM/dd/yyyy"));

                Thread.Sleep(2000);
                //Selects the Update button to add the event
                driver.FindElementByCssSelector("body > div.k-widget.k-window > div.k-popup-edit-form.k-window-content.k-content > div > div > a.k-button.k-button-icontext.k-primary.k-grid-update").Click();

                Thread.Sleep(1000);

                driver.FindElementByXPath("//*[@id='NavigationMenu']/li[2]").Click();

                Thread.Sleep(5000);

                //End test









            }
        }
    }
}
