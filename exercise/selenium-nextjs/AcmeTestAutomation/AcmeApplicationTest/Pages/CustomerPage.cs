using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace AcmeApplicationTest.Pages
{
    public class CustomerPage
    {
        private readonly IDriverWait _driver;

        public CustomerPage(IDriverWait driver)
        {
            _driver = driver;
        } 

        private IWebElement CustomerSideMenu => _driver.FindElement(By.LinkText("Customers"));

        public void ClickCustomerMenu() =>  CustomerSideMenu.Click();
    }
}