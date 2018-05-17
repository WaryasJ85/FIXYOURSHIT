using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Selenium.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Jasons_Home_Project
{
    [TestClass]
    public class ReportingToolTest
    {
        [TestMethod]
        public void Use_Chrome()
        {
            //start the browser driver
            using(var driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("https://us-dev.gmli2.bluewatertech.host");

                //Delays the browser~~~
               // Thread.Sleep(4000);

                driver.FindElementByXPath("//*[@id='NavigationMenu']/li/a").Click();

                //Thread.Sleep(3000);

                driver.FindElementById("Email").SendKeys("jwaryas@bluewatertech.com");

                //Thread.Sleep(5000);

                driver.FindElementById("Password").SendKeys("Droop420!");

                //Thread.Sleep(5000);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                //Thread.Sleep(5000);
              

            }
        }
    }
}
