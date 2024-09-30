using ICT3101_Calculator;

using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitionsDivision
    {
      
        private readonly CalculatorContext _calculatorContext;

        //public UsingCalculatorStepDefinitionsDivision(CalculatorContext calculatorContext)
        //{
        //    _calculatorContext = calculatorContext;
        //}

        //Context Injection for SpecFLow:
        private Calculator _calculator;

        private double _result;
        public UsingCalculatorStepDefinitionsDivision(Calculator calc)
        {
            this._calculator = calc;
        }

        // Step definition for the division operation
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            //_calculatorContext._result = _calculatorContext._calculator.Divide(p0, p1);
            _result = _calculator.Divide(p0, p1);
        }

        // Step definition to verify the division result
        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p1)
        {
            //Assert.That(_calculatorContext._result, Is.EqualTo(p1));
            Assert.That(_result, Is.EqualTo(p1));
        }

        // Step definition for the scenario with positive infinity (division by zero)
        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            //Assert.That(_calculatorContext._result, Is.EqualTo(double.PositiveInfinity));
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}