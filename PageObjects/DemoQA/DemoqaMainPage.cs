using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class DemoqaMainPage : BaseClass
    {
        public DemoqaMainPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By elementsBy = By.XPath("//div[@class='card-body']/*[contains(text(),'Elements')]");
        private By formsBy = By.XPath("//div[@class='card-body']/*[contains(text(),'Forms')]");

        //Methods
        public ElementsPage GoToElementsPage()
        {
            Click(elementsBy);
            return new ElementsPage(driver);
        }

        public FormsPage GoToFormsPage()
        {
            Click(formsBy);
            return new FormsPage(driver);
        }
    }
}
