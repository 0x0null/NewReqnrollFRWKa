using OpenQA.Selenium.Support.UI;

namespace NewReqnrollFRWK.Pages
{
    public class CartPage
    {
        IWebDriver driver;
        public CartPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        
         IWebElement CartPageClick => driver.FindElement(By.CssSelector(".shopping_cart_link"));
         IWebElement hamburgerMenuIcon => driver.FindElement(By.Id("react-burger-menu-btn"));
         IWebElement logoutBtn => driver.FindElement(By.XPath("//a[@id='logout_sidebar_link' and @data-test='logout-sidebar-link' and text()='Logout']"));
        IReadOnlyCollection<IWebElement> cartProductNames => driver.FindElements(By.XPath("//div[@class='inventory_item_name']"));


        /*private IWebElement productOne => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-onesie']"));
        private IWebElement productTwo => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-fleece-jacket']"));*/

        public void cartPageClick()
        {
            CartPageClick.Click();
        }


        
        public void ClickMenuIcon()=> hamburgerMenuIcon.Click();
        public void ClickLogout()
        {
            Thread.Sleep(3000);
            logoutBtn.Click();
        }

        public List<string> GetCartsProductNames()
        {
            List<string> cartProductName = new List<string>();
            for (int i = 0; i < cartProductNames.Count; i++)
            {
                cartProductName.Add(cartProductNames.ElementAt(i).Text);
            }

            return cartProductName;
        }
    }
}