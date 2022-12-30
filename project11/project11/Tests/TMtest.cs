using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using project11.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using project11.Utilities;

namespace project11.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TMtest :CommonDriver
    {
       
        
        [Test, Order(1),Description("check user can create new record")]
        public void createTM_Test()
        {
            //TM page object initialization and defintion
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.CreateTM(driver);
        }
        [Test, Order(2),Description("user can edit ")]
        public void EditTm_Test()
        {
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.EditTM(driver);
        }
        [Test, Order(3), Description("check user can delete")]
        public void deleteTM_Test()
        {
            TMpage Tmpageobj = new TMpage();
             Tmpageobj.DeleteTM(driver);
        }
        
       
    }
}
