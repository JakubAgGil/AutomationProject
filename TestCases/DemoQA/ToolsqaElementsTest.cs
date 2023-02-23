using NUnit.Framework;
using AutomationProject.SeleniumHelpers;
using AutomationProject.Navigations;
using FluentAssertions;
using AutomationProject.TestData.DemoQA;

namespace AutomationProject.TestCases.DemoQA
{
    [TestFixture]
    public class ToolsqaElementsTest : BaseTest
    {
        public ToolsqaElementsTest()
        {

        }

        [Test]
        public void TestDemoqaElements()
        {
            //When
            var navigator = new Navigator(driver)
                .NavigateToDemoqa()
                .GoToElementsPage()
                .GoToDynamicProperties()
                .ClickVisibleAfterButton()
                .GoToButtonsPage()
                .ClickDoubleClickButton()
                .RightClickRightClickButton()
                .ClickClickMeButton();

            //Then
            navigator.IsDoubleClickMessageEnabled().Should().BeTrue();
            navigator.IsRightClickMessageEnabled().Should().BeTrue();
            navigator.IsClickMessageEnabled().Should().BeTrue();
        }
    }
}
