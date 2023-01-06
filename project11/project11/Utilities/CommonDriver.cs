using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project11.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            //Login page object intialization and definition
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.LoginActions(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }

    internal class OneTimeAttribute : Attribute
    {
    }
}

