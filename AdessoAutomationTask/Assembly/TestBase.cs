using AdessoAutomationTask.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoAutomationTask.Assembly
{
    [TestFixture]
    public abstract class TestBase
    {
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void StartUpTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void EndTest()
        {
            Driver.Quit();
        }
    }
}
