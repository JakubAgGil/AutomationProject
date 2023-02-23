using AutomationProject.SeleniumHelpers;
using OpenQA.Selenium;

namespace AutomationProject.PageObjects.DemoQA
{
    public class PracticeFormPage : BaseClass
    {
        public PracticeFormPage(IWebDriver driver) : base(driver) { }

        //Page locators
        private By firstName = By.Id("firstName");
        private By lastName = By.CssSelector("[id='lastName']");
        private By userEmail = By.CssSelector("[id='userEmail']");
        private By maleRadio = By.CssSelector("[for='gender-radio-1']");
        private By getMaleRadio = By.CssSelector("[id='gender-radio-1']");
        private By getFemaleRadio = By.CssSelector("[id='gender-radio-2']");
        private By getOtherRadio = By.CssSelector("[id='gender-radio-3']");
        private By userNumber = By.CssSelector("[id='userNumber']");
        private By subjectsInput = By.CssSelector("[id='subjectsInput']");
        private By hobbiesCheckboxSports = By.CssSelector("[for='hobbies-checkbox-1']");
        private By hobbiesCheckboxMusic = By.CssSelector("[for='hobbies-checkbox-3']");
        private By getHobbiesCheckboxSports = By.CssSelector("[id='hobbies-checkbox-1']");
        private By getHobbiesCheckboxReading = By.CssSelector("[id='hobbies-checkbox-2']");
        private By getHobbiesCheckboxMusic = By.CssSelector("[id='hobbies-checkbox-3']");
        private By currentAddress = By.CssSelector("[id='currentAddress']");

        // Page actions
        // First name actions
        public PracticeFormPage EnterFirstName(string name)
        {
            EnterText(firstName, name);
            return this;
        }
        public bool IsFirstNameCorrect(string name)
        {
            return IsValueCorrect(firstName, name);
        }

        // Surname actions
        public PracticeFormPage EnterLastName(string surname)
        {
            EnterText(lastName, surname);
            return this;
        }
        public bool IsLastNameCorrect(string surname)
        {
            return IsValueCorrect(lastName, surname);
        }

        // Email actions
        public PracticeFormPage EnterEmail(string email)
        {
            EnterText(userEmail, email);
            return this;
        }
        public bool IsEmailCorrect(string email)
        {
            return IsValueCorrect(userEmail, email);
        }

        // Gender radio actions
        public PracticeFormPage SelectMaleGender()
        {
            Click(maleRadio);
            return this;
        }

        public bool IsMaleGenderSelected()
        {
            return IsButtonSelected(getMaleRadio);
        }
        public bool IsFemaleGenderSelected()
        {
            return IsButtonSelected(getFemaleRadio);
        }
        public bool IsOtherGenderSelected()
        {
            return IsButtonSelected(getOtherRadio);
        }

        // Mobile number actions
        public PracticeFormPage EnterPhoneNumber(string number)
        {
            EnterText(userNumber, number);
            return this;
        }
        public bool IsNumberCorrect(string number)
        {
            return IsValueCorrect(userNumber, number);
        }

        // Subject actions
        public PracticeFormPage EnterSubjects(string subject)
        {
            EnterAutocompleteText(subjectsInput, subject);
            return this;
        }

        // Hobbies actions
        public PracticeFormPage SelectSportsCheckbox()
        {
            Click(hobbiesCheckboxSports);
            return this;
        }
        public PracticeFormPage SelectMusicCheckbox()
        {
            Click(hobbiesCheckboxMusic);
            return this;
        }

        public bool IsSportsCheckboxSelected()
        {
            return IsButtonSelected(getHobbiesCheckboxSports);
        }
        public bool IsReadingCheckboxSelected()
        {
            return IsButtonSelected(getHobbiesCheckboxReading);
        }
        public bool IsMusicCheckboxSelected()
        {
            return IsButtonSelected(getHobbiesCheckboxMusic);
        }

        // Address actions
        public PracticeFormPage EnterCurrentAddress(string address)
        {
            EnterText(currentAddress, address);
            return this;
        }
        public bool IsCurrentAddressCorrect(string address)
        {
            return IsValueCorrect(currentAddress, address);
        }
    }
}
