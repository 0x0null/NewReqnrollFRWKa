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
         IReadOnlyCollection<IWebElement> cartProductNames => driver.FindElements(By.XPath("//div[@class='inventory_item_name']"));

        public void cartPageClick()
        {
            CartPageClick.Click();
        }
        
        public void ClickMenuIcon()=> hamburgerMenuIcon.Click();
        
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