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
		When I have entered <initialIntensity> , <decayParameter>  and <expectedFailure> into the calculator and press log_failure_intensity
		Then the log reliability result should be <result>
		Examples:
		| initialIntensity | decayParameter | expectedFailure | result |
		| 10               | 0.02           | 50              | 3.68   |
		| 55               | 0.03           | 45              | 14.26  |
		| 50               | 0.025          | 60              | 11.16  |
		
@LogarithmicReliability
Scenario Outline: Calculating Average Expected Failure using Logarithmic Model
		Given I have a calculator
		When I have entered <initialFailure> , <decayParameter>  and <time> into the calculator and press log_average_expected_failure
		Then the log reliability result should be <result>
		Examples:
		| initialFailure | decayParameter | time | result |
		| 2              | 0.11           | 4    | 5.74   |
		| 10             | 0.3            | 4    | 8.54   |
		| 6              | 0.5            | 2    | 3.89   |
		
@LogarithmicReliability
Scenario Outline: Calculating Failure Intensity using Logarithmic Model with negative input results in error
		Given I have a calculator
		When I have entered <initialIntensity> , <decayParameter>  and <expectedFailure> into the calculator and press log_failure_intensity
		Then the log reliability result will return an error
		Examples:
		| initialIntensity | decayParameter | expectedFailure |
		| 0                | -11            | 2               |
		| -10              | 3              | 4               |
		| 5                | 4              | -6              |

@LogarithmicReliability
Scenario Outline: Calculating Average Expected Failure using Logarithmic Model with negative input results in error
		Given I have a calculator
		When I have entered <initialFailure> , <decayParameter>  and <time> into the calculator and press log_average_expected_failure
		Then the log reliability result will return an error
		Examples:
		| initialFailure | decayParameter | time   |
		| -2             | 11             | 4      |
		| 10             | -3             | 4      |
		| 6              | 5              | -2     |
