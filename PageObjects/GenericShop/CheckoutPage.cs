using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class CheckoutPage : BaseClass
    {
        public CheckoutPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By firstNameBy = By.CssSelector("[id='billing_first_name']");
        private By lastNameBy = By.CssSelector("[id='billing_last_name']");
        private By countryField = By.CssSelector("[id='select2-billing_country-container']");
        private By countryBy = By.CssSelector("[class='select2-search__field']");
        private By countrySearchBar = By.CssSelector("[class='select2-results']");
        private By countryPoland = By.CssSelector("[id='select2-billing_country-results'] [id*='PL']");
        private By addressBy = By.CssSelector("[id='billing_address_1']");
        private By postcodeBy = By.CssSelector("[id='billing_postcode']");
        private By cityBy = By.CssSelector("[id='billing_city']");
        private By phoneBy = By.CssSelector("[id='billing_phone']");
        private By emailBy = By.CssSelector("[id='billing_email']");
        private By cashOnDelivery = By.CssSelector("[id='payment_method_cod']");
        private By placeOrder = By.CssSelector("[id='place_order']");
        private By blockUI = By.CssSelector("[class*='blockUI blockOverlay']");

        //Methods
        public CheckoutPage EnterFirstName(string firstName)
        {
            EnterText(firstNameBy, firstName);
            return this;
        }

        public CheckoutPage EnterLastName(string lastName)
        {
            EnterText(lastNameBy, lastName);
            return this;
        }

        public CheckoutPage EnterCountry(string country)
        {
            Click(countryField);
            EnterText(countryBy, country);
            Click(countryPoland);
            WaitForDisappear(countrySearchBar);
            return this;
        }

        public CheckoutPage EnterAddress(string address)
        {
            EnterText(addressBy, address);
            return this;
        }

        public CheckoutPage EnterPostCode(string postcode)
        {
            EnterText(postcodeBy, postcode);
            return this;
        }

        public CheckoutPage EnterCity(string city)
        {
            EnterText(cityBy, city);
            return this;
        }

        public CheckoutPage EnterPhoneNumber(string phoneNumber)
        {
            EnterText(phoneBy, phoneNumber);
            return this;
        }

        public CheckoutPage EnterEmail(string email)
        {
            EnterText(emailBy, email);
            return this;
        }

        public CheckoutPage SelectCashOnDelivery()
        {
            WaitForDisappear(blockUI);
            Click(cashOnDelivery);
            return this;
        }

        public OrderReceivedPage SubmitOrder()
        {
            Submit(placeOrder);
            return new OrderReceivedPage(driver);
        }
    }
}
