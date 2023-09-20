using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAdditionStepDefinitions
    {
        private double _result;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        // Context Injection for SpecFlow
        private Calculator? _calculator;
        
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.BinaryAddition(p0, p1);
        } 

        [Then(@"the addition result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}