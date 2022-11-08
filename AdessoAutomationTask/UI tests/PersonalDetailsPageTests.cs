using AdessoAutomationTask.Assembly;
using AdessoAutomationTask.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.UI_tests
{
    [TestFixture]
    public class PersonalDetailsPageTests : TestBase
    {
        [Test]
        public void CheckPersonalDetailsPageContent()
        {
            var personalDetailsPage = new PersonalDetailsPage(Driver);
            personalDetailsPage.Goto();
            personalDetailsPage.LogIn();
            personalDetailsPage.SubmitInitialDetails();

            var isTitleCorrect = personalDetailsPage.IsPageTitleCorrect();
            var isSubtitleCorrect = personalDetailsPage.IsPageSubtitleCorrect();
            var isTitleFieldDisplayed = personalDetailsPage.Title.Displayed;
            var isFirstNameFieldDisplayed = personalDetailsPage.FirstName.Displayed;
            var isLastNameFieldDisplayed = personalDetailsPage.LastName.Displayed;
            var isNationalityFieldDisplayed = personalDetailsPage.Nationality.Displayed;
            var isDateOfBirthFieldDisplayed = personalDetailsPage.BirthDate.Displayed;
            var isAddress1FieldDisplayed = personalDetailsPage.Address1.Displayed;
            var isAddress2FieldDisplayed = personalDetailsPage.Address2.Displayed;
            var isPostalCodeFieldDisplayed = personalDetailsPage.PostalCode.Displayed;
            var isCityFieldDisplayed = personalDetailsPage.City.Displayed;
            var isMobilePhoneFieldDisplayed = personalDetailsPage.MobilePhone.Displayed;
            var isAccountCurrencyFieldDisplayed = personalDetailsPage.AccountCurrency.Displayed;
            var isConsentCheckboxDisplayed = personalDetailsPage.ConsentCheckbox.Displayed;
            var isConsentCheckboxTextCorrect = personalDetailsPage.IsConsentCheckboxTextCorrect();
            var isBackButtonDisplayed = personalDetailsPage.BackButton.Displayed;
            var isCreateAccountButtonDisplayed = personalDetailsPage.CreateAccountButton.Displayed;

            var titleOptions = personalDetailsPage.GetTitleOptions();
            var expectedTitleOptions = new List<string> { "Mr", "Mrs", "Ms" };
            var nationalityOptions = personalDetailsPage.GetNationalityOptions();
            var expectedNationalityOptions = new List<string> { "Brasil", "China", "France", "Russia", "Germany", "USA" };
            var currencyOptions = personalDetailsPage.GetAccountCurrencyOptions();
            var expectedCurrencyOptions = new List<string> { "EUR", "USD" };

            var isNationalityTooltipMessageCorrect = personalDetailsPage.IsTooltipMessageCorrect(personalDetailsPage.NationalityTooltip, "The country you are a national of, as specified within an officially recognized document, such as a Passport.");
            var isDateOfBirthdayTooltipMessageCorrect = personalDetailsPage.IsTooltipMessageCorrect(personalDetailsPage.BirthDateTooltip, "You must be at least 18 years of age to use our services.");
            var isAddress1TooltipMessageCorrect = personalDetailsPage.IsTooltipMessageCorrect(personalDetailsPage.Address1Tooltip, "First line of the address of your primary residence e.g. Hedemannstasse 15; use “Address 2” if you require further space.");
            var isMobilePhoneTooltipMessageCorrect = personalDetailsPage.IsTooltipMessageCorrect(personalDetailsPage.MobilePhoneTooltip, "Provide your mobile number, including the country code.");
            var isAccountCurrencyTooltipMessageCorrect = personalDetailsPage.IsTooltipMessageCorrect(personalDetailsPage.AccountCurrencyTooltip, "Our services are currently only available in the currencies shown in the list.");

            Assert.Multiple(() =>
            {
                Assert.True(isTitleCorrect, "Personal Details page title is not correct.");
                Assert.True(isSubtitleCorrect, "Personal Details page subtitle is not correct.");
                Assert.True(isTitleFieldDisplayed, "Title field is missing.");
                Assert.True(isFirstNameFieldDisplayed, "First Name field is missing.");
                Assert.True(isLastNameFieldDisplayed, "Last Name field is missing.");
                Assert.True(isNationalityFieldDisplayed, "Nationality dropdown menu is missing.");
                Assert.True(isDateOfBirthFieldDisplayed, "Date of Birth field is missing.");
                Assert.True(isAddress1FieldDisplayed, "Address 1 field is missing.");
                Assert.True(isAddress2FieldDisplayed, "Address 2 field is missing.");
                Assert.True(isPostalCodeFieldDisplayed, "Postal Code field is missing.");
                Assert.True(isCityFieldDisplayed, "City field is missing.");
                Assert.True(isMobilePhoneFieldDisplayed, "Mobile Phone field is missing.");
                Assert.True(isAccountCurrencyFieldDisplayed, "Account Currency drodown menu is missing.");
                Assert.True(isConsentCheckboxDisplayed, "Consent checkbox is missing.");
                Assert.True(isBackButtonDisplayed, "Back Button is missing.");
                Assert.True(isCreateAccountButtonDisplayed, "Creat Account Button is missing.");
                CollectionAssert.AreEquivalent(expectedTitleOptions, titleOptions, "Title options are either missing or incorrect.");
                CollectionAssert.AreEquivalent(expectedNationalityOptions, nationalityOptions, "Nationality options are either missing or incorrect.");
                CollectionAssert.AreEquivalent(expectedCurrencyOptions, currencyOptions, "Account Currency options are either missing or incorrect.");
                Assert.True(isNationalityTooltipMessageCorrect, "Address 1 tooltip message is either missing or not correct.");
                Assert.True(isDateOfBirthdayTooltipMessageCorrect, "Date of Birth tooltip message is either missing or not correct.");
                Assert.True(isAddress1TooltipMessageCorrect, "Address 1 tooltip message is either missing or not correct.");
                Assert.True(isMobilePhoneTooltipMessageCorrect, "Mobile Phone tooltip message is either missing or not correct.");
                Assert.True(isAccountCurrencyTooltipMessageCorrect, "Account Curency tooltip message is either missing or not correct.");
            });
        }
    }
}
