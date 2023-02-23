using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class MyCartPage : BaseClass
    {
        public MyCartPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By toCheckoutbutton = By.CssSelector("[class='wc-proceed-to-checkout']");

        //Methods
        public CheckoutPage GoToCheckout()
        {
            Click(toCheckoutbutton);
            return new CheckoutPage(driver);
        }
    }
}
