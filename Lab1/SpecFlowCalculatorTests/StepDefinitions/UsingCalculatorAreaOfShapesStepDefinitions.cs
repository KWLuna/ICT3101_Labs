using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAreaOfShapesStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorAreaOfShapesStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press area_of_triangle")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressArea_Of_Triangle(int p0, int p1)
        {
            _result = _calculator.AreaOfTriangle(p0, p1);
        }

        [When(@"I have entered (.*) into the calculator and press area_of_circle")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressArea_Of_Circle(int p0)
        {
            _result = _calculator.AreaOfCircle(p0);
        }

        [Then(@"the area result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
