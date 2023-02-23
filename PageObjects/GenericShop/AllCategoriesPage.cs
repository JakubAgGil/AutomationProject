using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class AllCategoriesPage : BaseClass
    {
        public AllCategoriesPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By beltsCategory = By.CssSelector("[alt='Belts']");

        //Methods
        public BeltsPage GoToBeltsCategory()
        {
            Click(beltsCategory);
            return new BeltsPage(driver);
        }
    }
}
