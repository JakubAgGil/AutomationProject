using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class ElementsPage : BaseClass
    {
        public ElementsPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By dynamicPropertiesBy = By.XPath("//*[text() = 'Dynamic Properties']");

        //Methods
        public DynamicPropertiesPage GoToDynamicProperties()
        {
            MouseScroll(0, 250);
            Click(dynamicPropertiesBy);
            return new DynamicPropertiesPage(driver);
        }

    }
}
