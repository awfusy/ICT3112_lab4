
using System.Buffers.Text;
using NUnit.Framework;
using SpecFlowCalculatorTests.Support;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitionsAvailabilty
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitionsAvailabilty(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double mttf, double mttr)
        {
            _result = _calculator.Add(mttf, mttr);
        }

        //Availability = MTTF/MTBF = MTTF/ (MTTF+ MTTR)
        // Step for calculating Availability based on MTTF and MTBF
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double mttf, double mtbf)
        {
            _result = _calculator.Divide(mttf, mtbf);
        }

        // Additional step for calculating Availability using MTTR and MTTF directly
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability using MTTF and MTTR")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailabilityUsingMTTRAndMTTF(double mttf, double mttr)
        {
            _result =_calculator.Divide(mttf,_calculator.Add(mttf, mttr));
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
