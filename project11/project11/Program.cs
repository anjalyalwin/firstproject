using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//open chrome browser


IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//launge turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
 //identify username textbox and enter valid username
  
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

//identify password text box and enter valid pswd
IWebElement pswdtxtbox = driver.FindElement(By.Id("Password"));
pswdtxtbox.SendKeys("123123");

//click login botton
IWebElement loginbotton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbotton.Click();

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



