using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorSSIStepDefinitions
    {
        private double _result;
        // Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorSSIStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) , (.*) into the calculator and press defect_density")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressDefect_Density(int p0, int p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }
        [When(@"I have entered (.*) , (.*) , (.*) , (.*) , (.*) , (.*) into the calculator and press new_defect_density")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressNew_Defect_Density(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            _result = _calculator.ChangedDefectDensity(p0, p1, p2, p3, p4, p5);
        }

        [Then(@"the defect result should be (.*)")]
        public void ThenTheDefectResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
