using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace AcmeApplicationTest
{
    public class DriverFixture : IDriverFixture, IDisposable
    {
        public IWebDriver Driver { get; }

        public DriverFixture()
        {
            Driver = GetDriverType(BrowserType.Chrome);
            Driver.Navigate().GoToUrl("http://localhost:3000/");
            Driver.Manage().Window.Maximize();
        }

        private IWebDriver GetDriverType(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                BrowserType.Edge => new EdgeDriver(),
                _=> new ChromeDriver(),
            };
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Edge
        }
        public void Dispose()
        {
            Driver.Quit();
        }

        


    }
}
