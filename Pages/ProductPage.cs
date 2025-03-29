namespace NewReqnrollFRWK.Pages
{
    public class ProductPage
    {
        IWebDriver driver;
        public ProductPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        IWebElement productTitle => driver.FindElement(By.XPath("//span[@class='title' and @data-test='title' and text()='Products']"));
        IWebElement cartItem => driver.FindElement(By.CssSelector("[data-test='shopping-cart-badge']"));
        IWebElement cartPage => driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
        IWebElement logoutBtn => driver.FindElement(By.XPath("//a[@id='logout_sidebar_link' and @data-test='logout-sidebar-link' and text()='Logout']"));
        IWebElement productByName(string product) => driver.FindElement(By.XPath($"//div[text()='{product}']//following::div/button"));

        public bool IsProductTitleDisplayed() => productTitle.Displayed;

        public void CartPageClick()
        {
            cartPage.Click();
        }
        public void AddProductToCart(string product)
        {
            productByName(product).Click();
        }
        public bool IsCartItemsDisplayed() => cartItem.Displayed;

        public void ClickLogout()

        {
            Thread.Sleep(2000);
            logoutBtn.Click();
        }
    }
}