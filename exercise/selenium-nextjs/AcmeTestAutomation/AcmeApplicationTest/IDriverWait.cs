using OpenQA.Selenium;

namespace AcmeApplicationTest
{
    public interface IDriverWait
    {
        IWebElement FindElement(By elementLocator);
        IEnumerable<IWebElement> FindElements(By elementLocator);
    }
}