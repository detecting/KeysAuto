Feature: MoveToProperties
Background: 
	Given I have open the application
	Then I should see the Login Page title is "Log In"
	When I fill userName and password in form tick Remember Me and click Login Button
	| UserName         | Password   |
	| hm.z@outlook.com | morgan1985 |
	Then I will get into the "Dashboard" Page


	@Move to Properties page
Scenario: Move to Properties Page
	#Given at the Dashboard page
	When I select "Properties" under Owner
	Then I will go to "Properties | Property Community" Page
