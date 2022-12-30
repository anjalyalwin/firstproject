using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using project11.pages;
using project11.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_test: CommonDriver
    {
        [SetUp]
        public void Loginsteps()
        {
          

            //home page object initialization and definition
            Homepage homepageobj = new Homepage();
            homepageobj.GotoEmployepage(driver);

        }
        [Test, Order(1) ]
        public void CreateEmployee_Test()
        {
            Employepage employepageobj = new Employepage();
            employepageobj.CreateEmployee(driver);

        }

        [Test, Order(2)]
        public void editEmploye()
        {
            Employepage employepageobj = new Employepage();
            employepageobj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmploye()
        {
            Employepage employepageobj = new Employepage();
            employepageobj.DeleteEmployee(driver);
        }

        [TearDown]
        public void closingsteps()
        {
            driver.Quit();
        }

    }
}
