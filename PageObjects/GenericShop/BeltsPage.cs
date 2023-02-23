using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class BeltsPage : BaseClass
    {
        public BeltsPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By addToCart = By.CssSelector("[class='button product_type_simple add_to_cart_button ajax_add_to_cart']");
        private By topMyCartButton = By.CssSelector("[class='top-cart']");

        //Methods
        public BeltsPage AddBeltToCart()
        {
            Click(addToCart);
            return this;
        }
        public MyCartPage GotoMyCart()
        {
            Click(topMyCartButton);
            return new MyCartPage(driver);
        }
    }
}
