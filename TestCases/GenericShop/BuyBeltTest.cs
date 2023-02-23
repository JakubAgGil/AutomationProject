using AutomationProject.Navigations;
using AutomationProject.SeleniumHelpers;
using AutomationProject.TestData.GenericShop;
using FluentAssertions;
using NUnit.Framework;

namespace AutomationProject.TestCases.GenericShop
{
    [TestFixture]
    public class BuyBeltTest : BaseTest
    {
        public BuyBeltData buyBeltData;

        public BuyBeltTest()
        {
            buyBeltData = new BuyBeltData();
        }

        [Test]
        public void BuyBelt()
        {
            //Given
            string userLogin = buyBeltData.userName;
            string userPassword = buyBeltData.userPassword;
            string firstName = buyBeltData.firstName;
            string lastName = buyBeltData.lastName;
            string userCountry = buyBeltData.userCountry;
            string userAddress = buyBeltData.userAddress;
            string userPostCode = buyBeltData.userPostCode;
            string userCity = buyBeltData.userCity;
            string userPhone = buyBeltData.userPhone;
            string userEmail = buyBeltData.userEmail;
            string summaryPageTitle = buyBeltData.summaryPageTitle;

            //When
            var navigator = new Navigator(driver)
                .NavigateToMainPage()
                .GoToMyAccount()
                .EnterLogin(userLogin)
                .EnterPassword(userPassword)
                .Login()
                .GoToAllCategories()
                .GoToBeltsCategory()
                .AddBeltToCart()
                .GotoMyCart()
                .GoToCheckout()
                .EnterFirstName(firstName)
                .EnterLastName(lastName)
                //.EnterCountry(userCountry)
                .EnterAddress(userAddress)
                .EnterPostCode(userPostCode)
                .EnterCity(userCity)
                .EnterPhoneNumber(userPhone)
                .EnterEmail(userEmail)
                .SelectCashOnDelivery()
                .SubmitOrder();


            //Then
            navigator.IsTitleCorrect(summaryPageTitle)
                .Should()
                .BeTrue(because: $"Page title should be equal {summaryPageTitle}");
            navigator.IsEmailCorrect(userEmail)
                .Should()
                .BeTrue(because: $"Email should be equal {userEmail}");
        }
    }
}
