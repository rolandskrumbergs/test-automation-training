using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationTraining.SpecFlow.Page
{
    public class OrderPage
    {
        private readonly IWebDriver _driver;

        private readonly By _createNewButton = By.Id("create-new");
        private readonly By _bookCountLocator = By.Id("book-count");
        private readonly By _dvdCountLocator = By.Id("dvd-count");
        private readonly By _shirtCountLocator = By.Id("shirt-count");
        private readonly By _clientAddressLocator = By.Id("client-address");
        private readonly By _clientPhoneLocator = By.Id("client-phone");
        private readonly By _clientEmailLocator = By.Id("client-email"); 
        private readonly By _isCompanyLocator = By.Id("is-company");
        private readonly By _companyAddressLocator = By.Id("company-address");
        private readonly By _companyRegNrLocator = By.Id("company-reg-nr");
        private readonly By _companyPvnRegNrLocator = By.Id("company-pvn-reg-nr");
        private readonly By _deliveryAddresssLocator = By.Id("delivery-address");
        private readonly By _deliveryDetailsLocator = By.Id("delivery-details");
        private readonly By _deliveryDateLocator = By.Id("delivary-date");
        private readonly By _paymentTypeLocator = By.Id("payment-type");
        private readonly By _createButtonLocator = By.Id("create-button");


        public OrderPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://test-automation-training-app.azurewebsites.net/Orders");
        }

        public IWebElement CreateNewButton()
        {
            return _driver.FindElement(_createNewButton);
        }

        public InputField BookCountField() => new InputField(_driver.FindElement(_bookCountLocator));
        public InputField DvdCountField() => new InputField(_driver.FindElement(_dvdCountLocator));
        public InputField ShirtCountField() => new InputField(_driver.FindElement(_shirtCountLocator));
        public InputField ClientAddressField() => new InputField(_driver.FindElement(_clientAddressLocator));
        public InputField ClientPhoneField() => new InputField(_driver.FindElement(_clientPhoneLocator));
        public InputField ClientEmailField() => new InputField(_driver.FindElement(_clientEmailLocator));
        public CheckBox IsCompanyField() => new CheckBox(_driver.FindElement(_isCompanyLocator));
        public InputField CompanyAddressField() => new InputField(_driver.FindElement(_companyAddressLocator));
        public InputField CompanyRegNrField() => new InputField(_driver.FindElement(_companyRegNrLocator));
        public InputField CompanyPvnRegNrField() => new InputField(_driver.FindElement(_companyPvnRegNrLocator));
        public InputField DeliveryAddressField() => new InputField(_driver.FindElement(_deliveryAddresssLocator));
        public TextArea DeliveryDetailsField() => new TextArea(_driver.FindElement(_deliveryDetailsLocator));
        public InputField DeliveryDateField() => new InputField(_driver.FindElement(_deliveryDateLocator));
        public Dropdown PaymentTypeField() => new Dropdown(_driver.FindElement(_paymentTypeLocator));
        public IWebElement CreateButtonField() => _driver.FindElement(_createButtonLocator);
        
    }
}
