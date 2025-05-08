using OpenQA.Selenium;


namespace AcmeApplicationTest.Pages
{
    public class LoginPage
    {
        private readonly IDriverWait _driver;

        public LoginPage(IDriverWait driver)
        {
            _driver = driver;
        }

        IWebElement FirstLoginButton => _driver.FindElement(By.LinkText("Log in"));
        IWebElement EmailTxt => _driver.FindElement(By.XPath("//input[contains(@class,'peer block')][@name='email']"));
        IWebElement PasswordTxt => _driver.FindElement(By.XPath("//input[contains(@class,'peer block')][@name='password']"));
        IWebElement LoginButton => _driver.FindElement(By.XPath("//button[contains(@class,'flex h-10')][text()='Log in ']"));

        //click login button
        public void ClickLoginButton() {
            FirstLoginButton.Click();              
        }

        public void EnterLoginDetails(string email, string password)
        {
            EmailTxt.SendKeys(email);
            PasswordTxt.SendKeys(password);
            LoginButton.Click();
        }   
     


    }
}
