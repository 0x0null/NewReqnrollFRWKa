namespace NewReqnrollFRWK.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage lpage;
        ProductPage ppage;
        CartPage cpage;
        IWebDriver driver;
        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("browser"); //step4
            lpage = new LoginPage(driver);
            ppage = new ProductPage(driver);
            cpage = new CartPage(driver);
        }

        [Given("user is on saucedemo login page")]
        public void GivenUserIsOnSaucedemoLoginPage()
        {
            lpage.NavigateToSaudemoSite();
        }

        [When("user enters login credentials")]
        public void WhenUserEntersLoginCredentials(Table table)
        {
            lpage.EnterCredentials(table);
        }

        [Then("user click login button")]
        public void ThenUserClickLoginButton()
        {
            lpage.ClickLogin();
        }

        [Then("the current URL includes {string}")]
        public void ThenTheCurrentURLIncludes(string inventory)
        {
            lpage.ValidateSauceDemoWithInventoryURl();
        }

        [Then("user is on product page")]
        public void ThenUserIsOnProductPage()
        {
            Assert.IsTrue(ppage.IsProductTitleDisplayed(), "Product title is not displayed");
        }

        [When("the user adds the products which includes")]
        public void WhenTheUserAddsTheProductsWhichIncludes(DataTable dataTable)
        {
            foreach (var row in dataTable.Rows)
            {
                ppage.AddProductToCart(row[0]);
            }
        }

        //[Then("the cart icon shows a count of {int}")]
        //public void ThenTheCartIconShowsACountOf(int p0)
        //{
        //    Assert.IsTrue(ppage.IsCartItemsDisplayed(), "Cart items are not displayed");
        //}

        [When("user is on cart page")]
        public void WhenUserIsOnCartPage()
        {
            ppage.CartPageClick();
        }

        [Then("the product names are")]
        public void ThenTheProductNamesAre(DataTable dataTable)
        {
            var expectedProducts = dataTable.Rows.Select(r => r[0]).ToList();
            var actualProducts = cpage.GetCartsProductNames();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [Then("user click on the hambuger menu")]
        public void ThenUserClickOnTheHambugerMenu()
        {
            cpage.ClickMenuIcon();
        }

        [Then("user click on logout button")]
        public void ThenUserClickOnLogoutButton()
        {
            ppage.ClickLogout();
        }
    }
}