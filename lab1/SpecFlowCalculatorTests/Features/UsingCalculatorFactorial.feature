Feature: UsingCalculatorFactorial

A short summary of the feature

@Factorial
Scenario: Factorial one number
	Given I have a calculator
	When I have entered 5 into the calculator 
	Then the factorial result should be 120

@Factorial
Scenario: Factorial zero number
	Given I have a calculator
	When I have entered 0 into the calculator 
	Then the factorial result should be 1