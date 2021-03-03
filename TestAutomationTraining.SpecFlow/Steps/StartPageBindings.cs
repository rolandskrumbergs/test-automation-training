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
    public class StartPageBindings
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly StartPage _startPage;

        public StartPageBindings(ScenarioContext scenarioContext, IWebDriver driver)
        {
            _scenarioContext = scenarioContext;
            _startPage = new StartPage(driver);
        }

        [Given(@"I have navigated to start page")]
        public void GivenTheUrlIs()
        {
            _startPage.Navigate();
        }

        [Then(@"headline should be visible")]
        public void ThenHeadlineShouldBeVisible()
        {
            _startPage.Headline().Displayed.Should().BeTrue();
        }

    }
}
