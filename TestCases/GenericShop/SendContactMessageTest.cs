using AutomationProject.Navigations;
using AutomationProject.SeleniumHelpers;
using AutomationProject.TestData.GenericShop;
using FluentAssertions;
using NUnit.Framework;

namespace AutomationProject.TestCases.GenericShop
{
    [TestFixture]
    public class SendContactMessageTest : BaseTest
    {
        public SendContactMessageData sendContactMessageData;

        public SendContactMessageTest()
        {
            sendContactMessageData = new SendContactMessageData();
        }

        [Test]
        public void SendContactMessage()
        {
            //Given
            string yourName = sendContactMessageData.yourName;
            string yourEmail = sendContactMessageData.yourEmail;
            string subject = sendContactMessageData.subject;
            string yourMessage = sendContactMessageData.yourMessage;

            //When
            var navigator = new Navigator(driver)
                .NavigateToMainPage()
                .GoToContactPage()
                .EnterName(yourName)
                .EnterEmail(yourEmail)
                .EnterSubject(subject)
                .EnterMessage(yourMessage)
                .SubmitMessage();

            //Then
            navigator.IsNameCorrect(yourName)
                .Should()
                .BeTrue($"Name should be equal {yourName}");
            navigator.IsEmailCorrect(yourEmail)
                .Should()
                .BeTrue($"Email should be equal {yourEmail}");
            navigator.IsSubjectCorrect(subject)
                .Should()
                .BeTrue($"Subject should be equal {subject}");
            navigator.IsMessageCorrect(yourMessage)
                .Should()
                .BeTrue($"Message should be equal {yourMessage}");
        }
    }
}
