using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press basic_failure_intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrent_Failure_Intensity(double p0, double p1, double p2)
        {
            _result = _calculator.BasicFailureIntensity(p0, p1, p2);
        }

        [Then(@"the basic reliability result should be (.*)")]
        public void ThenTheReliabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press basic_average_expected_failure")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAverage_Expected_Failure(double p0, double p1, double p2)
        {
            _result = _calculator.BasicExpectedFailure(p0, p1, p2);
        }
    }
}
