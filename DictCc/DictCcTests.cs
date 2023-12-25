using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        [TearDown]

        public void TearDown() 
        
        { 
        
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Url = baseUrl;

            Assert.Pass();
        }
    }
}