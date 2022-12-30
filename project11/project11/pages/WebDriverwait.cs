using OpenQA.Selenium;

namespace project11.pages
{
    internal class WebDriverwait
    {
        private IWebDriver driver;
        private TimeSpan timeSpan;

        public WebDriverwait(IWebDriver driver, TimeSpan timeSpan)
        {
            this.driver = driver;
            this.timeSpan = timeSpan;
        }

        internal void Until(Func<IWebDriver, IWebElement> func)
        {
            throw new NotImplementedException();
        }
    }
}