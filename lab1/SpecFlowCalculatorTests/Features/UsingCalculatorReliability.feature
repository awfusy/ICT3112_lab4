Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Reliabilty
Scenario: Calculate the Basic Musa model's failures/intensities
Given I have a calculator
When I entered 100 failures in infinite time, 10 initial failures and 50 current failures
Then the reliability result should be 5

@Reliabilty
Scenario: Calculate the Average Basic Musa model's failures/intensities
Given I have a calculator
When I entered 100 failures in infinite time, 10 initial failures and after 100 cpu hours
Then the reliability result should be 100



