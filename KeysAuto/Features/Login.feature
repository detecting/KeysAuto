Feature: Login
	
	
@Login
Scenario: Login
	Given I have open the application
	Then I should see the Login Page title is "Log In"
	When I fill userName and password in form tick Remember Me and click Login Button
	| UserName         | Password   |
	| hm.z@outlook.com | morgan1985 |
	Then I will get into the "Dashboard" Page

	#Scenario: Login fail
	#Given I have open the application
	#Then I should see the Login Page
	#When I fill <UserName> and <Password> in form
	#| UserName         | Password   |
	#| hm.z@outlook.com | morgan198 |
	#And I tick the Remember Me and Login Button 
	#Then I will get see the error information

#need to login first


Scenario: Add New Property
#	Given open the New Property page
#	When I fill up the Property Details form
#
#	And I click Next button
#	Then move to Finance details Page

