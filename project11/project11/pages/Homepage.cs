using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11.pages
{
    public class Homepage
    {
        public void GotoTMpage(IWebDriver driver)
        {
            //navigate to time and material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

        }
        public void GotoEmployepage(IWebDriver driver)
        {
            //navigate to time and material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement employeoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            employeoption.Click();

        }
    }
}
