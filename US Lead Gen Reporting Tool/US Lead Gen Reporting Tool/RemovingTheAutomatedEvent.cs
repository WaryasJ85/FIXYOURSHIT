using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;



namespace US_Lead_Gen_Reporting_Tool
{
    [TestClass]
    public class RemovingTheAutomatedEvent
    {
        [TestMethod]
        public void Removing_The_Added_Event()
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

                //Thread.Sleep(2000);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                //Thread.Sleep(2000);

                //This is for mouseover actions.
                Actions builder = new Actions(driver);

                //Mouse over the administration dropdown
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]")).Perform();

                Thread.Sleep(4000);

                //Selects the System button in the mouseover drop down
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='NavigationMenu']/li[1]/div/ul/li[5]/span")).Perform();

                Thread.Sleep(2000);


                //Selects the Source Code button in the mouse hover dropdown
                driver.FindElementByCssSelector("#NavigationMenu > li.k-item.main-menu-item.k-state-default.k-first.k-state-border-down > div > ul > li.k-item.k-state-default.k-last.k-state-border-right > div > ul > li:nth-child(2)").Click();

                Thread.Sleep(2000);

                //Change page layout to 500 source codes per page
                driver.FindElementByXPath("//*[@id='_gSourceCodes']/div[2]/span[1]/span/span").Click();

                Thread.Sleep(1000);

                //Used to Select the 500 items per page in dropdown
                builder.MoveToElement(driver.FindElementByCssSelector("body > div.k-animation-container > div > div:nth-child(2) > ul > li:nth-child(4)")).Click().Perform();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='form0']/div/div/div")).Perform();

                Thread.Sleep(2000);

                //Delete the new source code that was added.
                builder.MoveToElement(driver.FindElementByXPath("//*[@id='_gSourceCodes']/table/tbody/tr[27]/td[18]/a")).Perform();

                Thread.Sleep(3000);

                driver.FindElementByXPath("//*[@id='_gSourceCodes']/table/tbody/tr[27]/td[18]/a").Click();

                Thread.Sleep(2000);

                builder.MoveToElement(driver.FindElementByCssSelector("#alertify-ok")).Perform();

                Thread.Sleep(2000);
                // ok button CssSelector:"#alertify-ok"  XPath:"//*[@id='alertify-ok']"
                driver.FindElementByCssSelector("#alertify-ok").Click();

                Thread.Sleep(5000);

                //Need to put an if statement here to verify that the Element has been deleted.

                builder.MoveToElement(driver.FindElementByXPath("//*[@id='form0']/div/div/div")).Perform();

                Thread.Sleep(10000);


            }
        }
    }
}
