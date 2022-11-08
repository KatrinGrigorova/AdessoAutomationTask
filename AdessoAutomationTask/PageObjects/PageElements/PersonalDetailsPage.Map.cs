using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class PersonalDetailsPage
    {
        public IWebElement PageTitle => Wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h2")));

        public IWebElement PageSubtitle => Wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h3")));

        public IWebElement Title => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Gender")));

        public IWebElement FirstName => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("FirstName")));

        public IWebElement LastName => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("LastName")));

        public IWebElement Nationality => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Nationality")));

        public By Tooltip => By.XPath("//span[@data-toggle='tooltip']");

        public IWebElement TooltipMessage => Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("tooltip-inner")));

        public By TooltipMessageTest => By.ClassName("tooltip-inner");

        public IWebElement NationalityTooltip => Driver.FindElement(RelativeBy.WithLocator(Tooltip).RightOf(Nationality));

        public IWebElement BirthDate => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("DateOfBirth")));

        public IWebElement BirthDateTooltip => Driver.FindElement(RelativeBy.WithLocator(Tooltip).RightOf(BirthDate));

        public IWebElement Address1 => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Address1")));

        public IWebElement Address1Tooltip => Driver.FindElement(RelativeBy.WithLocator(Tooltip).RightOf(Address1));

        public IWebElement Address2 => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Address2")));

        public IWebElement PostalCode => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("PostalCode")));

        public IWebElement City => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("City")));

        public IWebElement MobilePhone => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("MobilePhone")));

        public IWebElement MobilePhoneTooltip => Driver.FindElement(RelativeBy.WithLocator(Tooltip).RightOf(MobilePhone));

        public IWebElement AccountCurrency => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Currency")));

        public IWebElement AccountCurrencyTooltip => Driver.FindElement(RelativeBy.WithLocator(Tooltip).RightOf(AccountCurrency));

        public IWebElement ConsentCheckbox => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("IsEnrollmentConfirmed")));

        public IWebElement ConsentCheckboxLabel => Driver.FindElement(By.XPath("//label[@for='IsEnrollmentConfirmed']"));

        public IWebElement BackButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("back")));

        public IWebElement CreateAccountButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.Name("nextBtn")));

    }
}
