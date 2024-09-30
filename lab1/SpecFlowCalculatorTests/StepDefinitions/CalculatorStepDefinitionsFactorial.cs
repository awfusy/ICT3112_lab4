using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitionsFactorial
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitionsFactorial(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int number)
        {
            // This step sets the number for which the factorial is to be calculated.
            // Assuming that Calculator has a method to set the current number or can directly calculate factorial.
            _result = _calculator.Factorial(number);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(int expectedResult)
        {
            // This step verifies that the calculated factorial matches the expected result.
            Assert.That(_result,Is.EqualTo(expectedResult));
        }
    }
}
