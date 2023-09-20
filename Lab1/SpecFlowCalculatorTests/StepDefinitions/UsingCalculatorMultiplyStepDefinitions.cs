using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorMultiplyStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorMultiplyStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press multiply")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMultiply(double p0, double p1)
        {
            _result = _calculator.Multiply(p0, p1);
        }

        [Then(@"the multiply result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
