﻿using NUnit.Framework;
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

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            //Login page object intialization and definition
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
    


    }

