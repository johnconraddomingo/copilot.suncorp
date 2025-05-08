
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AcmeApplicationTest
{
    public class DriverWait : IDriverWait
    {
        private readonly IDriverFixture _driverFixture;
        private readonly Lazy<WebDriverWait> _webDriverWait;
        public float? TimeoutInterval;

        public DriverWait(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
            _webDriverWait = new Lazy<WebDriverWait>(GetWaitDriver);
        }

        private WebDriverWait GetWaitDriver()
        {
            //this method will till the driver object to locate every specific elements to wait for specific time only after the page is loaded 
            return new WebDriverWait(_driverFixture.Driver, timeout: TimeSpan.FromSeconds(TimeoutInterval ?? 30))
            {
                PollingInterval = TimeSpan.FromSeconds(TimeoutInterval ?? 1)

            };
        }

        public IWebElement FindElement(By elementLocator)
        {
            return _webDriverWait.Value.Until(_ => _driverFixture.Driver.FindElement(elementLocator));
        }

        public IEnumerable<IWebElement> FindElements(By elementLocator)
        {
            return _webDriverWait.Value.Until(_ => _driverFixture.Driver.FindElements(elementLocator));
        }
    }
}
