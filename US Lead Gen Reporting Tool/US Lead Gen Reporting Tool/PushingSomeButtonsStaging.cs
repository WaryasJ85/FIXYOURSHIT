using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace US_Lead_Gen_Reporting_Tool
{
    [TestClass]
    public class PushingSomeButtonsStaging
    {
        [TestMethod]
        public void Just_Use_Google_Chrome_STAGING()
        {
            using (var driver = new ChromeDriver())
            {

                // Maximize Browser Window
                driver.Manage().Window.Maximize();

                // Navigate to url 
                driver.Navigate().GoToUrl("https://us-stage.gmli2.bluewatertech.host");

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

                //Thread.Sleep(2500);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                //Stops the driver so the dropdown can load. 
                Thread.Sleep(1000);

                //Held Leads button
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first > div > ul > li.k-item.k-state-default.k-first > a").Click();

                Thread.Sleep(200);

                //Tab Pending Leads
                driver.FindElementByXPath("//*[@id='tabstrip']/ul/li[2]/a").Click();

                Thread.Sleep(1500);

                //Tab OverRidden Leads
                driver.FindElementByXPath("//*[@id='tabstrip']/ul/li[3]/a").Click();

                Thread.Sleep(1500);

                //Incoming Held Leads Tab
                driver.FindElementByXPath("//*[@id='tabstrip']/ul/li[1]/a").Click();

                Thread.Sleep(2000);

                //Radio button test.
                driver.FindElementByCssSelector("#tabstrip-1 > label:nth-child(5)").Click();

                Thread.Sleep(2000);

                //Search for ODC Leads. 
                driver.FindElementById("search").Click();

                Thread.Sleep(2000);

                //In the future i would like to put an if statement in here for further testing.

                //if (true)
                //{
                //    bla bla bla put if ture here
                //}

                //else
                //{

                //    If false go there

                //}

                driver.FindElementByXPath("//*[@id='NavigationMenu']/li[2]").Click();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1500);

                //VMM update button
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first > div > ul > li:nth-child(2) > a").Click();

                Thread.Sleep(200);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //DealerShips button
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first > div > ul > li:nth-child(3)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //Zipcodes button
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first > div > ul > li:nth-child(4)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //Product Specialist button (07/17/2018)
                driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/div/ul/li[5]/a").Click();

                Thread.Sleep(5000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Events button in the dropdown
                driver.FindElementByLinkText("Events").Click();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Source Codes Button in the system dropdown 
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(2)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the System Settings Button in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(3)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Plug-in Management in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(4)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Exporter Settings button in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(5)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Provision Keys button in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(6)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects The Purginator button in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(7)").Click();

                Thread.Sleep(1000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(1000);

                //span the system tab
                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Purge History button in the system dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li.k-item.k-state-default.k-last").Click();

                Thread.Sleep(2000);

                //Mouse hovers over the Reporting dropdown
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(3000);

                //Selects the Daily eamil button in the reporting dropdown
                driver.FindElementByLinkText("Daily Emails").Click();

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(2000);

                //Selects the EDC Lead Summary from the Reporting dropdown
                driver.FindElementByLinkText("EDC Lead Summary").Click();

                Thread.Sleep(200);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(2000);

                //Selects the Transmitted Leads from the Reporting dropdown
                driver.FindElementByLinkText("Transmitted Leads").Click();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(2000);

                driver.FindElementByLinkText("Lead Details").Click();

                Thread.Sleep(200);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(2000);

                driver.FindElementByLinkText("Multi-Brand Details").Click();

                Thread.Sleep(5000);





            }
        }
    }
}
