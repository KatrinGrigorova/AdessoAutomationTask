using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public partial class PersonalDetailsPage : InitialDetailsPage
    {
        public PersonalDetailsPage(IWebDriver driver) : base(driver) { }

        public bool IsPageTitleCorrect()
        {
            string pageTitle = PageTitle.Text;
            var isTitleCorrect = pageTitle.Equals("User Enrollment");

            return isTitleCorrect;
        }

        public bool IsPageSubtitleCorrect()
        {
            string pageSubtitle = PageSubtitle.Text;
            var isSubtitleCorrect = pageSubtitle.Equals("Personal Details");

            return isSubtitleCorrect;
        }

        public List<string> GetTitleOptions()
        {
            SelectElement titleOptions = new SelectElement(Title);
            IList<IWebElement> options = titleOptions.Options;
            List<string> list = new List<string> { };

            foreach (var item in options)
            {
                list.Add(item.Text);
            }

            return list;
        }

        public List<string> GetNationalityOptions()
        {
            SelectElement nationalityOptions = new SelectElement(Nationality);
            IList<IWebElement> options = nationalityOptions.Options;
            List<string> list = new List<string> { };

            foreach (var item in options)
            {
                list.Add(item.Text);
            }

            return list;
        }

        public bool? IsTooltipMessageCorrect(IWebElement element, string message)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            try
            {
                Wait.Until(ExpectedConditions.TextToBePresentInElementLocated(TooltipMessageTest, message));
            }
            catch (WebDriverException)
            {
                return false;
            }

            return true;
        }

        public List<string> GetAccountCurrencyOptions()
        {
            SelectElement currencyOptions = new SelectElement(AccountCurrency);
            IList<IWebElement> options = currencyOptions.Options;
            List<string> list = new List<string> { };

            foreach (var item in options)
            {
                list.Add(item.Text);
            }

            return list;
        }

        public bool IsConsentCheckboxTextCorrect()
        {
            var checkboxLabel = ConsentCheckboxLabel.Text;
            var isTextCorect = checkboxLabel.Equals("I confirm that I have read, understood and accept the general terms and conditions as well as the data protection.");

            return isTextCorect;
        }
    }
}
