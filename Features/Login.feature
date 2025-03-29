Feature: Login

As a user i want to be able to login

@ValidCreds
Scenario: Valid Login Scenarios
	Given user is on saucedemo login page
	When user enters login credentials
	| username       | password      |
	| standard_user  | secret_sauce  |
    Then user click login button
	And the current URL includes 'inventory'
	Then user is on product page
	When the user adds the products which includes 
		| product_name             |
		| Sauce Labs Onesie        |
		| Sauce Labs Fleece Jacket |
	Then the cart icon shows a count of 2
	When user is on cart page
	Then the product names are
		| product_name             |
		| Sauce Labs Onesie        |
		| Sauce Labs Fleece Jacket |
	Then user click on the hambuger menu
	And user click on logout button