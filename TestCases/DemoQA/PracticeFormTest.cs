using NUnit.Framework;
using AutomationProject.SeleniumHelpers;
using AutomationProject.Navigations;
using AutomationProject.TestData.DemoQA;
using FluentAssertions;

namespace AutomationProject.TestCases.DemoQA
{
    [TestFixture]
    public class PracticeFormTest : BaseTest
    {
        public PracticeFormData practiceFormData;

        public PracticeFormTest()
        {
            practiceFormData = new PracticeFormData();
        }

        [Test]
        public void SubmitPracticeForm()
        {
            //Given
            string firstName = practiceFormData.firstName;
            string lastName = practiceFormData.lastName;
            string userEmail = practiceFormData.userEmail;
            string phoneNumber = practiceFormData.userNumber;
            string userSubjects1 = practiceFormData.subjectsInput1;
            string userSubjects2 = practiceFormData.subjectsInput2;
            string currentAddress = practiceFormData.currentAddress;

            //When
            var navigator = new Navigator(driver)
                .NavigateToDemoqa()
                .GoToFormsPage()
                .GoToPracticeFormPage()
                .EnterFirstName(firstName)
                .EnterLastName(lastName)
                .EnterEmail(userEmail)
                .SelectMaleGender()
                .EnterPhoneNumber(phoneNumber)
                .EnterSubjects(userSubjects1)
                .EnterSubjects(userSubjects2)
                .SelectSportsCheckbox()
                .SelectMusicCheckbox()
                .EnterCurrentAddress(currentAddress);

            //Then
            navigator.IsFirstNameCorrect(firstName)
                .Should()
                .BeTrue(because: $"First name should be equal {firstName}");
            navigator.IsLastNameCorrect(lastName)
                .Should()
                .BeTrue(because: $"Last name should be equal {lastName}");
            navigator.IsEmailCorrect(userEmail)
                .Should()
                .BeTrue(because: $"Email should be equal {userEmail}");
            navigator.IsMaleGenderSelected().Should().BeTrue();
            navigator.IsFemaleGenderSelected().Should().BeFalse();
            navigator.IsOtherGenderSelected().Should().BeFalse();
            navigator.IsNumberCorrect(phoneNumber)
                .Should()
                .BeTrue(because: $"User number should be equal {phoneNumber}");
            navigator.IsSportsCheckboxSelected().Should().BeTrue();
            navigator.IsReadingCheckboxSelected().Should().BeFalse();
            navigator.IsMusicCheckboxSelected().Should().BeTrue();
            navigator.IsCurrentAddressCorrect(currentAddress)
                .Should()
                .BeTrue(because: $"Current address should be equal {currentAddress}");


        }
    }
}
