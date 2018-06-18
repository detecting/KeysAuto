Feature: Login
	Feature for Product Owner to login the page.
	
@Login
Scenario: Login success
	Given I have open the application
	Then I should see the Login Page
	When I fill <UserName> and <Password> in form
	| UserName         | Password   |
	| hm.z@outlook.com | morgan1985 |
	And I tick the Remember Me and Login Button 
	Then I will get into the Dashboard Page

	Scenario: Login fail
	Given I have open the application
	Then I should see the Login Page
	When I fill <UserName> and <Password> in form
	| UserName         | Password   |
	| hm.z@outlook.com | morgan198 |
	And I tick the Remember Me and Login Button 
	Then I will get see the error information

