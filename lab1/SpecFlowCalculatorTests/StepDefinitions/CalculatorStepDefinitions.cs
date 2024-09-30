using ICT3101_Calculator;

using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
      private readonly CalculatorContext _context;
        private Calculator _calculator;

        private double _result;
        public UsingCalculatorStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        //public UsingCalculatorStepDefinitions(CalculatorContext calculatorContext)  {
        //    _context = calculatorContext;        
        //}

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
           
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
           _result = _calculator.Add(p0, p1);
        }
        [Then(@"the addition result should be (.*)")]
        public void ThenTheAdditionResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}