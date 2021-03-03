using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationTraining.SpecFlow.Page
{
    public class CheckBox
    {
        private readonly ISearchContext _driver;
        private readonly By _checkBoxElement = By.CssSelector("");
        public CheckBox(ISearchContext driver)
        {
            _driver = driver;
        }

        public void Check() => _driver.FindElement(_checkBoxElement).Click();
    }
}
