using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class MainPage : BaseClass
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By topAccountButton = By.CssSelector("[class='top-account']");
        private By contactButton = By.CssSelector("[id='menu-item-108']");

        //Methods
        public LoginPage GoToMyAccount()
        {
            Click(topAccountButton);
            return new LoginPage(driver);
        }

        public ContactPage GoToContactPage()
        {
            Click(contactButton);
            return new ContactPage(driver);
        }
    }
}
