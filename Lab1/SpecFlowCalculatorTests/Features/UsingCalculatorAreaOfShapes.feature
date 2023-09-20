Feature: UsingCalculatorAreaOfShapes

@AreaOfShapes
Scenario Outline: Calculating Area of Triangle
		Given I have a calculator
		When I have entered <value1> and <value2> into the calculator and press area_of_triangle
		Then the area result should be <value3>
		Examples:
		| value1 | value2 | value3 |
		| 2      | 3	  | 3      |
		| 5      | 6      | 15     |
		| 4	     | 2      | 4      |

		
@AreaOfShapes
Scenario Outline: Calculating Area of Circle
		Given I have a calculator
		When I have entered <value1> into the calculator and press area_of_circle
		Then the area result should be <value2>
		Examples:
		| value1 | value2 | 
		| 4      | 50.27  | 
		| 11     | 380.13 | 
		| 2      | 12.57  | 
