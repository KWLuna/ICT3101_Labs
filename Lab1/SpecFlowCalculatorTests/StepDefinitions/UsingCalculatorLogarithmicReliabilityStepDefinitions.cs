using NUnit.Framework;
using System;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorLogarithmicReliabilityStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        Exception _exception;
        public UsingCalculatorLogarithmicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) , (.*)  and (.*) into the calculator and press log_failure_intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLog_Failure_Intensity(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.LogFailureIntensity(p0, p1, p2);
            }
            catch (ArgumentException ex)
            {
                _exception = ex;
            }
        }

        [When(@"I have entered (.*) , (.*)  and (.*) into the calculator and press log_average_expected_failure")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLog_Average_Expected_Failure(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.LogExpectedFailure(p0, p1, p2);
            }
            catch (ArgumentException ex)
            {
                _exception = ex;
            }
        }
       
        [Then(@"the log reliability result should be (.*)")]
        public void ThenTheLogReliabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the log reliability result will return an error")]
        public void ThenTheResultShouldBeError()
        {
            Assert.That(_exception, Is.TypeOf<ArgumentException>());
        }

    }
}
