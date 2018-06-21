Feature: FinanceDetails
Background: 
	Given I have open the application
	Then I should see the Login Page title is "Log In"
	When I fill userName and password in form tick Remember Me and click Login Button
	| UserName         | Password   |
	| hm.z@outlook.com | morgan1985 |
	Then I will get into the "Dashboard" Page
	When I select "Properties" under Owner
	Then I will go to "Properties | Property Community" Page
	Given I am at the PropertyOwners page
	When I click the  Add New Property button
	Then the Page will navigate to "Properties | Add New Property" Page
	When i fill the Property Details with the data from form below and also tick Owner Occupied and click Next button
	| PropertyName | PropertyType   | SearchAddress                                       | TargetRent | LandArea | FloorArea | Bedroom | Bathroom | ParkingSpace | YearBuilt | Description    | RentType |
	| Morgan House | Senior Housing | 20 Canberra Avenue, Lynfield, Auckland, New Zealand | 300        | 300      | 300       | 3       | 2        | 2            | 2015      | Good Condition | Monthly  |
	Then should mobe to "Finance Details" Page


@mytag
Scenario: Add Finance Details
	Given I get into the FinanceDetails page
	When I fill all the form and I click save button
	| PurchasePrice | Mortgage | HomeValue | HomeValueType |
	| 500           | 100      | 200       | Registered    |
	Then the item wiil be added and the page move to "Properties | Property Community" Page
