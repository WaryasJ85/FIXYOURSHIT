using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Selenium.Helper;
using Selenium.WebDriver;
using Selenium.WebForms;



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
                
                //This is for mouseover actions.
                Actions builder = new Actions(driver);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/span")).Perform();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-highlight.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last")).Perform();

                Thread.Sleep(2000);

                //Selects the Source Codes Button in the system dropdown 
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(2)").Click();

                Thread.Sleep(1000);


            }
        }
    }
}
