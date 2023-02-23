using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class LoginPage : BaseClass
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By usernameInput = By.CssSelector("[id='username']");
        private By passwordInput = By.CssSelector("[id='password']");
        private By login = By.CssSelector("[name='login']");
        private By dropdownCatergries = By.CssSelector("[title='Catergries']");
        private By dropdownAll = By.CssSelector("[title='All']");

        //Methods
        public LoginPage EnterLogin(string login)
        {
            EnterText(usernameInput, login);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            EnterText(passwordInput, password);
            return this;
        }

        public LoginPage Login()
        {
            Click(login);
            return this;
        }

        public AllCategoriesPage GoToAllCategories()
        {
            MouseSelect(dropdownCatergries);
            Click(dropdownAll);
            return new AllCategoriesPage(driver);
        }
    }
}
