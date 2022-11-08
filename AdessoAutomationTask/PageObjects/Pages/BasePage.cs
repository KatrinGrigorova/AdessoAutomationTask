using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace AdessoAutomationTask.PageObjects
{
    public class BasePage
    {
        private readonly string baseUrl;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            baseUrl = ConfigurationManager.AppSettings["UserEnrollmentAddress"];

        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void Goto()
        {
            Driver.Navigate().GoToUrl(baseUrl);
        }
    }
}
