Feature: Assignment Unit Cases
	In order to complete assignment # 3 
	As a devOps Engineer 
	I want these tests to pass


Scenario: Create New Employee
Given I navigate to my main page 
When I click on Create Add New Employee button 
And I enter valid Employee Information 
Then I should see employee in the list 

Scenario: Delete Employee 
Given I navigate to my main page 
When I click on Create Add New Employee button
And I enter valid Employee Information 
And I click on Delete button 
Then I should be on the main page again


