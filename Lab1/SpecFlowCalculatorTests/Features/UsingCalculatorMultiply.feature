Feature: UsingCalculatorMultiply
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculatorTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Multiply
Scenario Outline: Multiply two numbers
		Given I have a calculator
		When I have entered <value1> and <value2> into the calculator and press multiply
		Then the multiply result should be <value3>
		Examples:
		| value1 | value2 | value3 |
		| 1      | 11     | 11      |
		| 10     | 11     | 110     |
		| 11     | 2     | 22     |