using AutomationProject.PageObjects.DemoQA;
using AutomationProject.PageObjects.GenericShop;
using OpenQA.Selenium;

namespace AutomationProject.Navigations
{
    public class Navigator
    {
        public IWebDriver driver;

        public Navigator(IWebDriver driver)
        {
            this.driver = driver;
        }

        public DemoqaMainPage NavigateToDemoqa()
        {
            driver.Url = ("https://demoqa.com/");
            return new DemoqaMainPage(driver);
        }

        public MainPage NavigateToMainPage()
        {
            driver.Url = ("https://skleptest.pl/");
            return new MainPage(driver);
        }
    }
}
