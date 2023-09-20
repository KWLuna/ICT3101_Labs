Feature: UsingCalculatorLogarithmicReliability
		In order to calculate the Musa Logarithmic model's failures/intensities
		As a Software Quality Metric engineer
		I want to use my calculator to do this
		// Epic:
		// - Allow Engineers to calcuate defect densite of system
		// - Implement Custom Calculation for new total of Shipped Source Insturctions (SSI)
		// - Implement Calculatation Method of Musa Log Model to calculate failure intensity and expected failures

@LogarithmicReliability
Scenario Outline: Calculating Failure Intensity using Logarithmic Model
		Given I have a calculator
		When I have entered <value1> , <value2>  and <value3> into the calculator and press log_failure_intensity
		Then the log reliability result should be <value4>
		Examples:
		| value1 | value2 | value3 | value4 |
		| 1      | 11     | 2      | -4.5   |
		| 10     | 3      | 4      | 2.5    |
		| 5      | 4      | 6      | 1.67   |
		
@LogarithmicReliability
Scenario Outline: Calculating Average Expected Failure using Logarithmic Model
		Given I have a calculator
		When I have entered <value1> , <value2>  and <value3> into the calculator and press log_average_expected_failure
		Then the log reliability result should be <value4>
		Examples:
		| value1 | value2 | value3 | value4 |
		| 2      | 11     | 4      | 0.40   |
		| 10     | 3      | 4      | 1.58   |
		| 6      | 5      | 2      | 0.82   |
