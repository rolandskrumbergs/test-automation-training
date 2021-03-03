using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationTraining.SpecFlow.Page
{
    public class StartPage
    {
        private readonly IWebDriver _driver;

        private readonly By _headlineLocator = By.CssSelector(".display-4");

        public StartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://test-automation-training-app.azurewebsites.net/");
        }

        public IWebElement Headline()
        {
            return _driver.FindElement(_headlineLocator);
        }
    }
}
