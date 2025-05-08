using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AcmeApplicationTest.Pages
{
    public class InvoicesPage
    {
        private readonly IDriverWait _driver;

        public InvoicesPage(IDriverWait driver)
        {
            _driver = driver;
        }
        private IWebElement InvoicesSideMenu => _driver.FindElement(By.LinkText("Invoices"));

        public void ClickInvoicesMenu() => InvoicesSideMenu.Click();

        IWebElement CreateInvoiceButton => _driver.FindElement(By.XPath("//span[@class='hidden md:block']"));



        IWebElement SearchInvoiceTxt => _driver.FindElement(By.XPath("//input[contains(@class,'peer block')]"));
        IWebElement EditInvoiceIcon => _driver.FindElement(By.XPath("//table/tbody/tr[1]//a[contains(@href,'/dashboard/invoices/')][contains(@class,'rounded-md')]"));
        IWebElement DeleteInvoiceIcon => _driver.FindElement(By.XPath("//table/tbody/tr[1]//form//button[@type='submit']"));
        IWebElement EditInvoiceBtn => _driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement CancelButton => _driver.FindElement(By.LinkText("Cancel"));


        public void ClickCreateInvoiceButton() => CreateInvoiceButton.Click();



        public void CancelInvoice() => CancelButton.Click();

        //write a method to search for invoice and delete the record
        public void DeleteInvoice(string customerName)
        {
            SearchInvoiceTxt.SendKeys(customerName);
            DeleteInvoiceIcon.Click();
            //  DeleteModalDeleteButton.Click();
        }

        //write a method to search for invoice and edit the record
        public void EditInvoice(string CustomerName, string customer, string amount)
        {
            SearchInvoiceTxt.SendKeys(CustomerName);
            //wait for the search results to load
            Thread.Sleep(4000);
            // Click the edit icon (pencil) for the first invoice in the search results
            EditInvoiceIcon.Click();
            //In the Edit Invoice page select the customer name from the dropdown
            SelectElement select = new SelectElement(CustomerDdl);
            select.SelectByText(customer);
            // Clear the amount field and enter the new amount
            AmountTxt.Clear();
            // Enter the new amount    
            AmountTxt.SendKeys(amount);
            // Click the Save button to save the changes
            EditInvoiceBtn.Click();
        }

       

    }
}
