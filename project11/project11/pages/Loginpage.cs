using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace project11.pages
{
    public class Loginpage
    {
        public void LoginActions(IWebDriver driver)
        {

           
            driver.Manage().Window.Maximize();


            //launge turnup portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            Thread.Sleep(1000);

            try
            {
                //identify username textbox and enter valid username

                IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
                usernametextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("turnup portal page did not launch", ex.Message);
            }

            //identify password text box and enter valid pswd
            IWebElement pswdtxtbox = driver.FindElement(By.Id("Password"));
            pswdtxtbox.SendKeys("123123");

            //click login botton
            IWebElement loginbotton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbotton.Click();

        }
    }
}
