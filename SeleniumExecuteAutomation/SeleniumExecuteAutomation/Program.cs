using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExecuteAutomation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //IWebDriver driver = new InternetExplorerDriver(@"C:\Users\806590\Source\Repos\CSharpTests\SeleniumExecuteAutomation\packages\Selenium.WebDriver.IEDriver.3.2.0\driver");
            //InternetExplorerOptions options = new InternetExplorerOptions();
            //options.EnablePersistentHover = false;
            //IWebDriver driver = new InternetExplorerDriver(@"C:\Users\806590\Source\Repos\CSharpTests\SeleniumExecuteAutomation\packages\Selenium.WebDriver.IEDriver.3.2.0\driver", options);
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            var ActionToolsButton = driver.FindElement(By.XPath("//span[@id='Automation Tools']"));
            var Selenium = driver.FindElement(By.CssSelector("a span#Selenium"));
            var SeleniumWebDriver = driver.FindElement(By.CssSelector("a[href='seleniumwebdriver.html'] span"));

            By s1 = By.CssSelector("a span#Selenium");
            By s2 = By.CssSelector("//span[@id='Automation Tools']");
            By s3 = By.CssSelector("a[href='seleniumwebdriver.html'] span");
            //;
            Actions action = new Actions(driver);
            action.MoveToElement(ActionToolsButton).Perform();
            new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(ExpectedConditions.ElementExists((s1)));
            action.MoveToElement(Selenium).Perform();
            Thread.Sleep(2000);
            var x = action.MoveToElement(SeleniumWebDriver);
            x.Click().Build().Perform();
            
            Thread.Sleep(2000);
            if (driver.Url == "http://executeautomation.com/demosite/seleniumwebdriver.html")
            {
                Console.WriteLine("The Page has opened successfully");
            }

            else Console.WriteLine("Page is not opened!!!!");
          
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
