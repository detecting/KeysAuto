Feature: AddNewProperties
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
Scenario: Add Property Finance and so on
Given I am at the PropertyOwners page
	When I click the  Add New Property button
	Then the Page will navigate to "Properties | Add New Property" Page
	When i fill the Property Details with the data from form below and also tick Owner Occupied and click Next button
	| PropertyName | SearchAddress                                       | Number | Street | Suburb | City | PostCode | Region | TargetRent | LandArea | FloorArea | Bedroom | Bathroom | ParkingSpace | YearBuilt | Description | Rent Type |
	| Morgan House | 20 Canberra Avenue, Lynfield, Auckland, New Zealand | 20     | Canberra Avenue | Lynfield | Auckland | 1042     | Auckland | 300        | 300      | 300       | 3       | 2        | 2            | 2015      | Good Condition | Weekly    |
	Then should mobe to "Finance Details" Page
