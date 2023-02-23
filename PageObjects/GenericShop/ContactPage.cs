using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.GenericShop
{
    public class ContactPage : BaseClass
    {
        public ContactPage(IWebDriver driver) : base(driver) { }

        //Locators
        private By nameBy = By.CssSelector("[name='your-name']");
        private By emailBy = By.CssSelector("[name='your-email']");
        private By subjectBy = By.CssSelector("[name='your-subject']");
        private By messageBy = By.CssSelector("[name='your-message']");
        private By sendBy = By.CssSelector("[class='wpcf7-form-control wpcf7-submit']");

        //Methods
        public ContactPage EnterName(string name)
        {
            EnterText(nameBy, name);
            return this;
        }
        public bool IsNameCorrect(string name)
        {
            return IsValueCorrect(nameBy, name);
        }

        public ContactPage EnterEmail(string email) 
        {
            EnterText(emailBy, email);
            return this; 
        }
        public bool IsEmailCorrect(string email)
        {
            return IsValueCorrect(emailBy, email);
        }

        public ContactPage EnterSubject(string subject)
        {
            EnterText(subjectBy, subject);
            return this;
        }
        public bool IsSubjectCorrect(string subject)
        {
            return IsValueCorrect(subjectBy, subject);
        }

        public ContactPage EnterMessage(string message)
        {
            EnterText(messageBy, message);
            return this;
        }
        public bool IsMessageCorrect(string message)
        {
            return IsValueCorrect(messageBy, message);
        }

        public ContactPage SubmitMessage()
        {
            Submit(sendBy);
            return this;
        }
    }
}
