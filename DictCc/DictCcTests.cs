using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

namespace DictCc
{
    public class DictCcTests
    {

        private const string baseUrl = "https://www.dict.cc/";
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {

            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        

        [Test]
        public void Test1()
        {
            driver.Url = baseUrl;

            var acceptCookies = driver.FindElement(By.Id("accept-choices"));
            acceptCookies.Click();  

            var inputField = driver.FindElement(By.Id("sinp"));
            inputField.SendKeys("press");

            var searchField = driver.FindElement(By.ClassName("inp1"));
            searchField.Click();

            var thirdRowTable = driver.FindElement(By.CssSelector("#tr1"));
            var thirdRowSecondColumn = thirdRowTable.FindElement(By.CssSelector("#tr1 > td:nth-child(3)"));

            //var result = thirdRowSecondColumn.Text;

            //var resultValue = Regex.Match(result, @"\d+").Value;

            Assert.That(thirdRowSecondColumn.Text.Contains("drücken"));    


        }
    }
}