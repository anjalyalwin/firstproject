using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project11.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11.pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //check if user has logged in successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (hellohari.Text == "hello hari")
            {

                Console.WriteLine("login succeful , test pass ");
            }
            else
            {
                Console.WriteLine("login failed, test failed");

            }

            //click on create botton
            Thread.Sleep(1000);
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();
            //Thread.Sleep(500);

            wait.waitforwebelementtobeexist(driver, "xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 5);

            //select time in the typecode dropdown
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();

            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeoption.Click();

            //enter code in the code text box
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("firstproject");

            //enter description in the description text box
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("firstproject");


            //enter price in the price unit text box
            IWebElement overlappingtab = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlappingtab.Click();
            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.SendKeys("8");

            //click on save botton
            IWebElement savebotton = driver.FindElement(By.Id("SaveButton"));
            savebotton.Click();
            // Thread.Sleep(2000);
            wait.waitforwebelementtobeexist(driver, "xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",5);
            //var wait = new WebDriverwait(driver, new TimeSpan(0, 0, 5));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")));



            //check if new time record has been created successfully
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastpagebutton.Click();

            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //example1;
            Assert.That(newcode.Text == "firstproject", "Actual code and expected code do not match");
            //example2;
            //if (newcode.Text == "firstproject")
           // {
             //   Assert.Pass("Time record created successfully");
          //  }
           // else
           // {

            //    Assert.Fail("Time record hasn't been created successfully");
           // }



        }
        public void EditTM(IWebDriver driver)
        { 

        }
        public void DeleteTM(IWebDriver driver) 
        {
        
        }
    }
}
