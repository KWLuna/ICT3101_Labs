Feature: UsingCalculatorSSI
		In order to calculate the Musa Logarithmic model's failures/intensities
		As a Software Quality Metric engineer
		I want to use my calculator to do this
		// Epic:
		// - Allow Engineers to calcuate defect densite of system
		// - Implement Custom Calculation for new total of Shipped Source Insturctions (SSI)
		// - Implement Calculatation Method of Musa Log Model to calculate failure intensity and expected failures

@SSI
Scenario Outline: Calculating Defect Density
		Given I have a calculator
		When I have entered <value1> , <value2> into the calculator and press defect_density
		Then the defect result should be <value3>
		Examples:
		| value1 | value2 | value3 |
		| 550    | 50     | 11     |
		| 100    | 20     | 5      |
		| 400    | 70     | 6      |
		
@SSI
Scenario Outline: Calculating new Defect Density
		Given I have a calculator
		When I have entered <value1> , <value2> , <value3> , <value4> , <value5> , <value6> into the calculator and press new_defect_density
		Then the defect result should be <value7>
		Examples:
		| value1 | value2 | value3 | value4 | value5 | value6 | value7 |
		| 550    | 50     | 25     | 7      | 0      | 5      | 8      |
		| 100    | 20     | 30     | 0      | 5      | 0      | 2      |
		| 400    | 70     | 50     | 10     | 200    | 25     | 5      |
	
