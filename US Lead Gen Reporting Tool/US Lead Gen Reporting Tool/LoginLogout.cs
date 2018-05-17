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




namespace US_Lead_Gen_Reporting_Tool
{
    [TestClass]
    public class LoginLogout
    {
        [TestMethod]
        public void Chrome_Web_Browser()
        {
            //Starting Chrome Driver
            using(var driver = new ChromeDriver())
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

                //Thread.Sleep(2000);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                //Thread.Sleep(2000);

                //This is for mouseover actions.
                Actions builder = new Actions(driver);

                //  and .Perform() are needed to make the hidden drop down action to happen?
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[4]/span")).Perform();

                Thread.Sleep(200);

                // Used CSS selector for this element to be found, fucking stupid shit!
               builder.MoveToElement(driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-last > div > ul > li.k-item.k-state-default.k-last")).Click().Perform();

                Thread.Sleep(5000);


                
            }
        }
    }
}
