using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class LoginPage
    {
        public IWebElement Email => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Email")));

        public IWebElement Password => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Password")));

        public IWebElement SubmitButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='submit']")));
    }
}
