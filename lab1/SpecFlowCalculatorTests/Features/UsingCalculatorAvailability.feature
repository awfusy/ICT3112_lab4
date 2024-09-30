Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

# MTBF = MTTF + MTTR 
@Availability
Scenario: Calculating MTBF
Given I have a calculator
When I have entered 200 and 10 into the calculator and press MTBF
Then the availability result should be 210

# Availability = MTTF/MTBF = MTTF/ (MTTF+ MTTR)
@Availability
Scenario: Calculating Availability
Given I have a calculator
When I have entered 200 and 210 into the calculator and press Availability
Then the availability result should be 0.95

@Availability
Scenario: Calculating Availablity using MTTF and MTTR
Given I have a calculator
When I have entered 720 and 42 into the calculator and press Availability using MTTF and MTTR
Then the availability result should be 0.94


