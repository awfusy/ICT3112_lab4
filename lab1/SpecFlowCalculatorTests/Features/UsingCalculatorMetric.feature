Feature: UsingCalculatorMetric

## EPIC: Enhance Command Line Calculator to Support Advanced Quality Metrics

## user story: As a system quality engineers 
## I want to use numbers of defects and size 
## So that I can know the defect density of the 2nd release

## user story 2: 
## As a system quality engineers 
## I want to use Musa logarithmic model
## so tht I can know the failure intensity

@Metric
Scenario: Calculate the new KCSI
Given I have a calculator
When I have entered initial release KCSI of 50, 20 new KLOC and 4 changed/deleted
Then the reliability metric result should be 66

@Metric 
Scenario: Claculate the expected number of failures using logarithmic model
Given I have a calculator
When I have entered 0.02 decay parameter, 10 initial failures and 50 current failures
Then the reliability metric result should be 3.68

@Metric
Scenario: Calculate the avergage expected number of failures using logarithmic model
Given I have a calculator
When I have entered 0.02 decay parameter, 10 initial failures and 100 cpu hours
Then the reliability metric result should be 152


