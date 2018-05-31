using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace US_Lead_Gen_Reporting_Tool
{
    [TestClass]
    public class PullReportsStaging
    {
        [TestMethod]
        public void Pulls_The_EDC_Lead_Report_STAGING()
        {
            using (var driver = new ChromeDriver())
            {
                //sets the date for the event being created
                // This will be for todays date
                DateTime y = DateTime.Today.Date;

                //This will be used for the start date of the auto show
                DateTime x = y.AddDays(5);



                //Maximizes the window
                driver.Manage().Window.Maximize();

                //Go to web page
                driver.Navigate().GoToUrl("https://us-stage.gmli2.bluewatertech.host");

                // Find SignIn btn and Click
                driver.FindElementByXPath("//*[@id='NavigationMenu']/li").Click();

                driver.FindElementByName("Email").SendKeys("jwaryas@bluewatertech.com");

                driver.FindElementByName("Password").SendKeys("Droop420!");

                Thread.Sleep(200);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                //This is for mouseover actions.
                Actions builder = new Actions(driver);

                //Mouse hovers over the Reporting dropdown
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[3]/span")).Perform();

                Thread.Sleep(2000);

                //Selects the EDC Lead Summary from the Reporting dropdown
                driver.FindElementByLinkText("EDC Lead Summary").Click();

                Thread.Sleep(1000);

                //Selects all events
                driver.FindElementByXPath("//*[@id='criteriaForm']/table[2]/tbody/tr[2]/td[1]/div/div[1]/div[1]/button").Click();

                Thread.Sleep(1000);

                //Selects all Brands
                driver.FindElementByXPath("//*[@id='criteriaForm']/table[2]/tbody/tr[2]/td[2]/div/div[1]/div[1]/button").Click();

                Thread.Sleep(1000);

                //Selects All Product Specialist
                driver.FindElementByXPath("//*[@id='criteriaForm']/table[2]/tbody/tr[2]/td[3]/div/div[1]/div[1]/button").Click();

                //Selects the submit
                driver.FindElementByXPath("//*[@id='submitReport']").Click();


                Thread.Sleep(8000);

            }
        }
    }
}
