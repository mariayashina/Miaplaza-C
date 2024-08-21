using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics.CodeAnalysis;

namespace Miaplaza
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _onlineSchoolLink = By.XPath("//*[contains(text(), 'Online High School')]");
        private readonly By _applyToMohsLink = By.XPath("//*[@id='menu-item-4357']");
        private readonly By _navigateToParentInfo = By.XPath("//button[@elname='next']");
        private readonly By _nameInputField = By.XPath("//*[@elname='First']");
        private const string _firstName = "Maria";
        private readonly By _lastNameInputField = By.XPath("//*[@elname='Last']");
        private const string _lastName = "Yashina";
        private readonly By _eMailInputField = By.XPath("//*[@id='Email-arialabel']");
        private const string _eMail = "maria.yashina@test.com";
        private readonly By _phoneCodeDropDown = By.XPath("//*[@class='selected-dial-code']");
        private readonly By _phoneCodeGermany = By.XPath("//*[contains(text(), 'Germany')]");
        private readonly By _phoneNumberInputField = By.XPath("//*[@id='PhoneNumber']");
        private const string _phoneNumber = "1111111111";
        private readonly By _secondParentDropDown = By.XPath("//span[@id='select2-Dropdown-arialabel-container']");
        private readonly By _noSecondParent = By.XPath("//li[@id='select2-Dropdown-arialabel-result-84zy-No']");
        private readonly By _dateInputField = By.XPath("//*[@id='Date-date']");
        private const string _date = "01-Oct-2024";
        private readonly By _navigateToStudentInfo = By.XPath("//button[contains(@aria-label, 'Navigates to page 3 out of 4')]");
        

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var navigateToMiaPrep = driver.FindElement(_onlineSchoolLink);
            navigateToMiaPrep.Click();
            var navigateToApplicationForm = driver.FindElement(_applyToMohsLink);
            navigateToApplicationForm.Click();
            var navigateToParentInfoClick = driver.FindElement(_navigateToParentInfo);
            navigateToParentInfoClick.Click();
            var firstNameInput = driver.FindElement(_nameInputField);
            firstNameInput.SendKeys(_firstName);
            var lastNameInput = driver.FindElement(_lastNameInputField);
            lastNameInput.SendKeys(_lastName);
            var eMail = driver.FindElement(_eMailInputField);
            eMail.SendKeys(_eMail);
            var phoneCodeDropDownOpen = driver.FindElement(_phoneCodeDropDown);
            phoneCodeDropDownOpen.Click();
            var phoneCodeGermanySelect = driver.FindElement(_phoneCodeGermany);
            phoneCodeGermanySelect.Click();
            var phoneNumberInput = driver.FindElement(_phoneNumberInputField);
            phoneNumberInput.SendKeys(_phoneNumber);
            var secondParentDropDownOpen = driver.FindElement(_secondParentDropDown);
            secondParentDropDownOpen.Click();
            var noSecondParentSelection = driver.FindElement(_noSecondParent);
            noSecondParentSelection.Click();
            var dateInput = driver.FindElement(_dateInputField);
            dateInput.SendKeys(_date);
            var navigateToStudentInfoClick = driver.FindElement (_navigateToStudentInfo);
            navigateToStudentInfoClick.Click();


        }
        [TearDown]
        public void TearDown() 
        {
        }
    }
}