using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class DynamicPropertiesPage : BaseClass
    {
        public DynamicPropertiesPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By visibleAfter = By.CssSelector("[id='visibleAfter']");
        private By buttonsBy = By.XPath("//*[contains(text(),'Buttons')]");


        //Methods
        public DynamicPropertiesPage ClickVisibleAfterButton()
        {
            Click(visibleAfter);
            return this;
        }

        public ButtonsPage GoToButtonsPage()
        {
            Click(buttonsBy);
            return new ButtonsPage(driver);
        }
    }
}
