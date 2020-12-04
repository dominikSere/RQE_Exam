Feature: SpecFlowFeature1
	As a User of a Calculator
	I want to be able to add, subtract, multiply and divide numbers
	So that I can calculate differrent arithmetic Calculations



@mytag
Scenario: Add two numbers
	Given the first number is 6
	And the second number is 3
	When the two numbers are added
	Then the result should be 9


@mytag
Scenario: Subtract two numbers
	Given the first number is 6
	And the second number is 3
	When the two numbers are subtracted
	Then the result should be 3

	@mytag
Scenario: Multiply two numbers
	Given the first number is 6
	And the second number is 3
	When the two numbers are multiplied
	Then the result should be 18

	@mytag
	Scenario: Divide two numbers
Given the first number is 6
And the second number is 3
When the two numbers are divided
Then the result should be 2