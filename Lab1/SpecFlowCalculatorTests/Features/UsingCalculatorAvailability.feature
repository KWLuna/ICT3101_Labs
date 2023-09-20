Feature: UsingCalculatorAvailability
		In order to calculator MTBF and Availability
		As someone who struggle with math
		I want to be able to use my calculator to do this

@Availability
Scenario Outline: Calculating MTBF
		Given I have a calculator
		When I have entered <value1>  and <value2> into the calculator and press MTBF
		Then the availability result should be <value3>
		Examples:
		| value1 | value2 | value3 |
		| 1      | 5      | 6      |
		| 10     | 12     | 22     |
		| 5      | 6      | 11     |

@Availability
Scenario: Calculating Availability
		Given I have a calculator
		When I have entered <value1> and <value2> into the calculator and press Availability
		Then the availability result should be <value3>
		Examples:
		| value1 | value2 | value3 |
		| 5      | 5      | 1      |
		| 4      | 2      | 2      |
		| 10     | 5      | 2      |
