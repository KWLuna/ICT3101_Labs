Feature: UsingCalculatorAvailability
		In order to calculator MTBF and Availability
		As someone who struggle with math
		I want to be able to use my calculator to do this

@Availability
Scenario Outline: Calculating MTBF
		Given I have a calculator
		When I have entered <MTTR>  and <MTTF> into the calculator and press MTBF
		Then the availability result should be <result>
		Examples:
		| MTTR | MTTF | result |
		| 1    | 5    | 6      |
		| 10   | 12   | 22     |
		| 5    | 6    | 11     |

@Availability
Scenario: Calculating Availability
		Given I have a calculator
		When I have entered <MTTF> and <MTBF> into the calculator and press Availability
		Then the availability result should be <result>
		Examples:
		| MTTF | MTBF | result |
		| 5    | 5    | 1      |
		| 4    | 2    | 2      |
		| 10   | 5    | 2      |
