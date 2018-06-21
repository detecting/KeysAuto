Feature: Searching
Background: 
	Given I have open the application
	Then I should see the Login Page title is "Log In"
	When I fill userName and password in form tick Remember Me and click Login Button
	| UserName         | Password   |
	| hm.z@outlook.com | morgan1985 |
	Then I will get into the "Dashboard" Page
	When I select "Properties" under Owner
	Then I will go to "Properties | Property Community" Page


@mytag
Scenario: Searching what was created
	Given I get into PropertyOwners
	When I have entered "Morgan House" in to the search box and I press the search button
	Then the result should show up

