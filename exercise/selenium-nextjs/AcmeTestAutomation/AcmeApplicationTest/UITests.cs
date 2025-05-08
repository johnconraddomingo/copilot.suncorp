using AcmeApplicationTest.Pages;


namespace AcmeApplicationTest
{
    public class UITests : IDisposable
    {

        private readonly IDriverFixture _driverFixture;
        private readonly IDriverWait _driverWait;
        private readonly LoginPage _loginPage;
        private readonly InvoicesPage _invoicesPage;
        private readonly CustomerPage _customerPage;

        public UITests()
        {
            _driverFixture = new DriverFixture();
            _driverWait = new DriverWait(_driverFixture);
            _loginPage = new LoginPage(_driverWait);
            _invoicesPage = new InvoicesPage(_driverWait);
            _customerPage = new CustomerPage(_driverWait);
        }



        [Fact]
        public void VerifyEditInvoice()
        {
            try
            {
                // Login
                _loginPage.ClickLoginButton();
                _loginPage.EnterLoginDetails("user@nextmail.com", "123456");
                Thread.Sleep(2000);
                // Navigate to Invoices page
                _invoicesPage.ClickInvoicesLink();
                // Search for Customer and Edit invoice
                _invoicesPage.EditInvoice("Delba de Oliveira", "Amy Burns", "500");
            }
            catch (Exception ex)
            {
                throw new Exception($"Edit invoice test failed: {ex.Message}", ex);
            }
        }

        [Fact]
        public void VerifyDeleteInvoice()
        {
            _loginPage.ClickLoginButton();
            _loginPage.EnterLoginDetails("user@nextmail.com", "123456");
            Thread.Sleep(2000);
            _invoicesPage.ClickInvoicesMenu();
            _invoicesPage.DeleteInvoice("Delba de Oliveira");
        }

        [Fact]
        public void VerifyCustomersMenu()
        {
            _loginPage.ClickLoginButton();
            _loginPage.EnterLoginDetails("user@nextmail.com", "123456");
            Thread.Sleep(2000);
            _customerPage.ClickCustomerMenu();
        }

        public void Dispose()
        {
            _driverFixture.Driver?.Quit();
        }
    }
}