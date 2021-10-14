Feature: TMFeature
	As a turnUp portal admin
	I would like to create, edit and  delete time and material records
	So that I can manage employees time and material successfully

@tmtest @regression
Scenario: A_Create time and material with valid details
	Given I logged in to turnup prtal successfully
	And I navigate to time and material page
	When I create time and material record
	Then Then the record shoul be create successfully

@tmtest @regression
Scenario Outline: B_Edit time and material with valid details
	Given I logged in to turnup prtal successfully
	And I navigate to time and material page
	When I edit '<addCode2>' , <descriptionTextBox1>' time and material record
	Then the record should be edited successfully '<addCode2>' 

	Examples: 
	| addCode2 | descriptionTextBox1 |
	| M_Edit_1    | M_changed_1    |
	| M_Edit_2    | M_changed_2    |

	@tmtest @regression
Scenario Outline: C_Delete time and material 
	Given I logged in to turnup prtal successfully
	And I navigate to time and material page
	When I delete time and material record
	Then the record should be deleted successfully