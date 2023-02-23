using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;
using static OpenQA.Selenium.PrintOptions;

namespace AutomationProject.PageObjects.GenericShop
{
    public class OrderReceivedPage : BaseClass
    {
        public OrderReceivedPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By pageTitle = By.XPath("//header/*[contains(text(),'Order received')]");
        private By emailBy = By.CssSelector("[class='woocommerce-customer-details--email']");

        //Methods
        public bool IsTitleCorrect(string title)
        {
            return IsTextCorrect(pageTitle, title);
        }
        public bool IsEmailCorrect(string email)
        {
            return IsTextCorrect(emailBy, email);
        }
    }
}
