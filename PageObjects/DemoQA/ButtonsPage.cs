using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class ButtonsPage : BaseClass
    {
        public ButtonsPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By doubleClickBy = By.CssSelector("[id='doubleClickBtn']");
        private By rightClickBy = By.CssSelector("[id='rightClickBtn']");
        private By clickMeBy = By.XPath("//*[text() = 'Click Me']");
        private By doubleClickMessage = By.CssSelector("[id='doubleClickMessage']");
        private By rightClickMessage = By.CssSelector("[id='rightClickMessage']");
        private By clickMeMessage = By.CssSelector("[id='dynamicClickMessage']");

        //Methods
        public ButtonsPage ClickDoubleClickButton()
        {
            DoubleClick(doubleClickBy);
            return this;
        }

        public ButtonsPage RightClickRightClickButton()
        {
            RightClick(rightClickBy);
            return this;
        }

        public ButtonsPage ClickClickMeButton()
        {
            Click(clickMeBy);
            return this;
        }

        public bool IsDoubleClickMessageEnabled()
        {
            return IsEnabled(doubleClickMessage);
        }
        public bool IsRightClickMessageEnabled()
        {
            return IsEnabled(rightClickMessage);
        }
        public bool IsClickMessageEnabled()
        {
            return IsEnabled(clickMeMessage);
        }
    }
}
