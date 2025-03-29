using OpenQA.Selenium.Support.UI;

namespace NewReqnrollFRWK.Pages
{
    public class ProductPage
    {
        IWebDriver driver;
        public ProductPage(IWebDriver _driver)
        {
            driver = _driver;
        }

         IWebElement productTitle => driver.FindElement( By.XPath("//span[@class='title' and @data-test='title' and text()='Products']"));
         IWebElement boltTShirtAddToCartBtn => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']"));
         IWebElement sauceLabsFleeceJacketBtn => driver.FindElement(By.XPath("//button[@data-test='add-to-cart-sauce-labs-fleece-jacket']"));
         IWebElement cartItem => driver.FindElement(By.CssSelector("[data-test='shopping-cart-badge']"));
         IWebElement cartPage => driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
        IWebElement hamburgerMenuIcon => driver.FindElement(By.Id("react-burger-menu-btn"));
         IWebElement logoutBtn => driver.FindElement(By.XPath("//a[@id='logout_sidebar_link' and @data-test='logout-sidebar-link' and text()='Logout']"));
        IWebElement productByName(string product) => driver.FindElement(By.XPath($"//div[text()='{product}']//following::div/button"));
       
        
        public bool IsProductTitleDisplayed() => productTitle.Displayed;

        public void CartPageClick()
        {
            cartPage.Click();
        }

        public bool IsCartItemsDisplayed()=> cartItem.Displayed;
        public void ClickMenuIcon()=> hamburgerMenuIcon.Click();
        public void ClickLogout()
        {
            Thread.Sleep(3000);
            logoutBtn.Click();
        }

        public void AddProductToCart(string product)
        {
            productByName(product).Click();
        }
    }
}