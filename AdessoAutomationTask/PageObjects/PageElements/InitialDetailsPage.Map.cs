using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class InitialDetailsPage
    {
        public IWebElement CountryOfResidence => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Country")));        

        public IWebElement ConfirmPassword => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ConfirmPassword")));
    }
}
