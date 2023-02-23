using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class FormsPage : BaseClass
    {
        public FormsPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By practiceFormBy = By.XPath("//*[text() = 'Practice Form']");

        //Methods
        public PracticeFormPage GoToPracticeFormPage()
        {
            Click(practiceFormBy);
            return new PracticeFormPage(driver);
        }

    }
}
