using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace TestAutomationTraining.SpecFlow.Hooks
{
    [Binding]
    public class WebDriverHooks
    {
        private readonly IObjectContainer _container;

        public WebDriverHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArgument("--window-size=1366,668");

            var driver = new ChromeDriver(options);

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void DestroyWebDriver()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver == null)
            {
                return;
            }

            driver.Close();
            driver.Quit();
        }
    }
}
