Feature: UsingCalculatorBasicReliability
		In order to calculate the Basic Musa model's failures/intensities
		As a Software Quality Metric enthusiast
		I want to use my calculator to do this

@BasicReliability
Scenario Outline: Calculating Current Failure Intensity using Basic Model
		Given I have a calculator
		When I have entered <value1> , <value2>  and <value3> into the calculator and press basic_failure_intensity
		Then the basic reliability result should be <value4>
		Examples:
		| value1 | value2 | value3 | value4 |
		| 1      | 11     | 2      | -4.5   |
		| 10     | 3      | 4      | 2.5    |
		| 5      | 4      | 6      | 1.67   |
		
@BasicReliability
Scenario Outline: Calculating Average Number of Expected Failure using Basic Model
		Given I have a calculator
		When I have entered <value1> , <value2>  and <value3> into the calculator and press basic_average_expected_failure
		Then the basic reliability result should be <value4>
		Examples:
		| value1 | value2 | value3 | value4 |
		| 2      | 11     | 4      | 2      |
		| 10     | 3      | 4      | 6.99   |
		| 6      | 5      | 2      | 4.87   |
