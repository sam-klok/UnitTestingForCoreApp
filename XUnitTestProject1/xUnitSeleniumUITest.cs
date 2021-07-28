using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Newtonsoft.Json;

namespace XUnitTestProject
{
    public class xUnitSeleniumUITest
    {
        public const string URL_GIT = @"https://github.com/sam-klok/FibonacciSequenceAlgorithm";

        IWebDriver driver;

        public xUnitSeleniumUITest() 
        {
            //driver = new InternetExplorerDriver();
            driver = new ChromeDriver();
        }

        ~xUnitSeleniumUITest()
        {
            driver.Dispose();
        }

        [Fact]
        public void CheckIfPageContainsTextAbout()
        {
            driver.Navigate().GoToUrl(URL_GIT);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10)); // let's wait 10 sec max


            // XPath from browser:
            // //*[@id="repo-content-pjax-container"]/div/div[2]/div[2]/div/div[1]/div/h2

            var xpath = "//h2[contains(text(),'About')]";

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(
                By.XPath(xpath)));

            var text = driver.FindElement(By.XPath(xpath));
            Assert.NotNull(text);

        }
    }
}
