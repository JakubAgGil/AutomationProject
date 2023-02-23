using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationProject.SeleniumHelpers
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "geckodriver.exe");
            driver = new FirefoxDriver(path);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
