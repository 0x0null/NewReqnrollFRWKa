namespace NewReqnrollFRWK.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        private IWebElement userName => driver.FindElement(By.Id("user-name"));
        private IWebElement passWord => driver.FindElement(By.Id("password"));
        private IWebElement loginBtn => driver.FindElement(By.Id("login-button"));

        public void NavigateToSaudemoSite()
        {
            var readFromJson = new readFromJson();
            var url = readFromJson.getUrlValue("url:saucedemourl");
            driver.Navigate().GoToUrl(url);
        }

        public void EnterCredentials(Table table)
        {
            userName.SendKeys(table.Rows[0]["username"]);
            passWord.SendKeys(table.Rows[0]["password"]);
        }

        public void ClickLogin() => loginBtn.Click();

        public void ValidateSauceDemoWithInventoryURl()
        {
            var readFromJson = new readFromJson();
            var url = readFromJson.getUrlValue("url:suacedemoUrl");
        }
    }
}