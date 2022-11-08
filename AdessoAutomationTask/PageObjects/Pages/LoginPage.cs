using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public void EnterEmail()
        {
            var email = ConfigurationManager.AppSettings["Email"];
            Email.SendKeys(email);
        }

        public void EnterPassword(string passValue)
        {
            var pass = ConfigurationManager.AppSettings[passValue];
            Password.SendKeys(pass);
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

        public void LogIn()
        {
            EnterEmail();
            EnterPassword("Password");
            ClickSubmitButton();
        }
    }
}
