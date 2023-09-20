Feature: UsingCalculatorFactorial

@Factorial
Scenario Outline: Factorizing a number
		Given I have a calculator
		When I have entered <value1> into the calculator and press factorize
		Then the factorial result should be <value2>
		Examples:
		| value1 | value2 |
		| 3      | 6      |
		| 5      | 120    |
		| 6      | 720    |