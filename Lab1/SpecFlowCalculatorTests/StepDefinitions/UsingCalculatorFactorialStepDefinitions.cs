using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorFactorialStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) into the calculator and press factorize")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorize(double p0)
        {
            _result = _calculator.Factorial(p0);
        }


        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
