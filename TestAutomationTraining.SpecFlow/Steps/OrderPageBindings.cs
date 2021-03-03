using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomationTraining.SpecFlow.Page;

namespace TestAutomationTraining.SpecFlow.Steps
{
    [Binding]
    public class OrderPageBindings
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        private readonly OrderPage _orderPage;

        public OrderPageBindings(ScenarioContext scenarioContext, IWebDriver driver)
        {
            _scenarioContext = scenarioContext;
            _driver = driver;
            _orderPage = new OrderPage(driver);
        }

        [Given(@"I have navigated to orders page")]
        public void GivenTheUrlIs()
        {
            _orderPage.Navigate();
        }

        [Given(@"clicked create new button")]
        public void ClickedCreateNewButton()
        {
            _orderPage.CreateNewButton().Click();
        }

        [Then(@"order form is visible")]
        public void OrderPageIsOpened()
        {
            _driver.Url.Should().Be("https://test-automation-training-app.azurewebsites.net/Orders/Create");
        }
    }
}
