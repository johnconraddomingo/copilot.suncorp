using OpenQA.Selenium;

namespace AcmeApplicationTest
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}