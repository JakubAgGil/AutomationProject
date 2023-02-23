using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationProject.SeleniumHelpers
{
    public class BaseClass
    {
        public IWebDriver driver;
        private TimeSpan defaultTimeout = TimeSpan.FromSeconds(10);
        private WebDriverWait wait;
        private Actions actions;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, defaultTimeout);
            actions = new Actions(driver);
        }

        //Wait methods
        public IWebElement WaitToBeClickable(By elementBy)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(elementBy));
        }

        public IWebElement WaitElementExists(By elementBy)
        {
            return wait.Until(ExpectedConditions.ElementExists(elementBy));
        }

        public void WaitForDisappear(By elementBy)
        {
            if (driver.FindElements(elementBy).Count > 0)
            {
                wait.Until(ExpectedConditions.ElementIsVisible(elementBy));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(elementBy));
            }
        }

        //Basic actions
        public void Click(By elementBy)
        {
            WaitToBeClickable(elementBy).Click();
        }

        public void RightClick(By elementBy)
        {
            actions.ContextClick(WaitToBeClickable(elementBy)).Perform();
        }

        public void DoubleClick(By elementBy)
        {
            actions.DoubleClick(WaitToBeClickable(elementBy)).Perform();
        }

        public void Submit(By elementBy)
        {
            WaitToBeClickable(elementBy).Submit();
        }

        public void EnterText(By elementBy, string text)
        {
            IWebElement webElement = WaitToBeClickable(elementBy);
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public void EnterAutocompleteText(By elementBy, string text)
        {
            IWebElement webElement = WaitToBeClickable(elementBy);
            webElement.Clear();
            webElement.SendKeys(text);
            webElement.SendKeys(Keys.Tab);
        }

        public void MouseSelect(By elementBy)
        {
            actions.MoveToElement(WaitToBeClickable(elementBy)).Perform();
        }
        public void MouseScroll(int x, int y)
        {
            actions.ScrollByAmount(x, y).Perform();
        }

        //Confirmations
        public bool IsValueCorrect(By elementBy, string expectedText)
        {
            string currentText = WaitElementExists(elementBy).GetAttribute("value");
            return currentText.Equals(expectedText);
        }

        public bool IsTextCorrect(By elementBy, string expectedValue)
        {
            string currentValue = WaitElementExists(elementBy).Text;
            return currentValue.Equals(expectedValue);
        }

        public bool IsButtonSelected(By elementBy)
        {
            return WaitElementExists(elementBy).Selected;
        }

        public bool IsEnabled(By elementBy)
        {
            if (driver.FindElements(elementBy).Count > 0)
            {
                return WaitElementExists(elementBy).Enabled;
            }
            return false;
        }
    }
}
