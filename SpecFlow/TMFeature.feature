Feature: TMFeature
	As a turnUp portal admin
	I would like to create, edit and  delete time and material records
	So that I can manage employees time and material successfully

@tmtest @regression
Scenario: Create time and material with valid details
	Given I logged in to turnup prtal successfully
	And I navigate to time and material page
	When I create time and material record
	Then Then the record shoul be create successfully