using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationTraining.SpecFlow.Page
{
    public class Dropdown
    {
        private readonly ISearchContext _driver;

        private readonly By _labelSelector = By.CssSelector("label");
        private readonly By _inputSelector = By.CssSelector("select");
        private readonly By _validationSelector = By.CssSelector("span");

        public Dropdown(ISearchContext driver)
        {
            _driver = driver;
        }

        public string LabelText() => _driver.FindElement(_labelSelector).Text;

        public IWebElement Element => _driver.FindElement(_inputSelector);

        public void SetValue(string input) => new SelectElement(_driver.FindElement(_inputSelector)).SelectByText(input);

        public string ValidationText() => _driver.FindElement(_validationSelector).Text;
    }
}
