using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationTraining.SpecFlow.Page
{
    public class TextArea
    {
        private readonly ISearchContext _driver;

        private readonly By _labelSelector = By.CssSelector("label");
        private readonly By _inputSelector = By.CssSelector("textarea");
        private readonly By _validationSelector = By.CssSelector("span");

        public TextArea(ISearchContext driver)
        {
            _driver = driver;
        }

        public string LabelText() => _driver.FindElement(_labelSelector).Text;

        public IWebElement Input => _driver.FindElement(_inputSelector);

        public void SetInput(string input) => _driver.FindElement(_inputSelector).SendKeys(input);

        public string ValidationText() => _driver.FindElement(_validationSelector).Text;
    }
}
