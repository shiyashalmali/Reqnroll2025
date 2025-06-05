Feature: Login
A short summary of the feature
test the login functionality
Background: 
    Given User is on the orangehrm login page
 
@Sanity
Scenario: Verify login with valid credentials
	When User enters the username "Admin" and password "admin123" in the text fields
	When User clicks on the submit button
	Then User is navigated to home page
 
	#scenario outline passing test parameters
@Regression
Scenario Outline: Verify login with test parameters
	When user enters the "<username>" and "<password>"
	When User clicks on the submit button
	Then User is navigated to home page
	Examples:
	| username | password |
	| Admin    | admin123 |
	| Ad       | adn      |
	| Adn      | adhjd    |
 
	#data tables passing arguments
	@Regr
Scenario Outline: Verify login with data table parameters
	When user enters the "<username>" and "<password>"
	When User clicks on the submit button
	Then User is navigated to home page
	Then User selected city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |
	Examples:
	| username | password |
	| Admin    | admin123 |
	| Ad       | adn      |
	| Adn      | adhjd    |
 
@Regression,@Functional
Scenario: Verify login with valid credentails
	When User enters the username "Admin" and password "admin123" in the text fields
	When User clicks on submit button
	Then User is navigated to home page