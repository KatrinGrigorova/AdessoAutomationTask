using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class InitialDetailsPage : LoginPage
    {
        public InitialDetailsPage(IWebDriver driver) : base(driver) { }

        public void SelectCountryOfResidence()
        {
            SelectElement country = new SelectElement(CountryOfResidence);
            country.SelectByIndex(0);
        }

        public void PopulateConfirmPasswordField()
        {
            var pass = ConfigurationManager.AppSettings["NewPassword"];
            ConfirmPassword.SendKeys(pass);
        }

        public void SubmitInitialDetails()
        {
            SelectCountryOfResidence();
            EnterEmail();
            EnterPassword("NewPassword");
            PopulateConfirmPasswordField();
            ClickSubmitButton();
        }
    }
}
