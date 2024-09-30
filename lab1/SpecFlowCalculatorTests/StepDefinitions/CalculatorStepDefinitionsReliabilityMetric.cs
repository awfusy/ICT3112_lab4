using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitionsReliabilityMetric
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitionsReliabilityMetric(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [When(@"I have entered initial release KCSI of (.*), (.*) new KLOC and (.*) changed/deleted")]
        public void WhenIEnteredinitalReleasedKCSINewKLOCAndChanges(double initalKCSI, double newKLOC, double deletedOrChange)
        {
            _result = _calculator.SecondReleaseDefectDensity(initalKCSI, newKLOC, deletedOrChange);
        }

        [When(@"I have entered (.*) decay parameter, (.*) initial failures and (.*) cpu hours")]
        public void WhenIEnteredFailureDecayParameterAndInitialFailuresAndCpuHours(double decayParameter, double initialFailures, double cpuHours)
        {
            _result = _calculator.AvgLogFailureIntensity(decayParameter, initialFailures, cpuHours);
        }
        [When(@"I have entered (.*) decay parameter, (.*) initial failures and (.*) current failures")]
        public void WhenIEnteredFailureDecayParameterAndInitialFailuresAndCurrentFailures(double decayParameter, double initialFailures, double cpuFailures)
        {
            _result = _calculator.logFailureIntensity(decayParameter, initialFailures, cpuFailures);
        }

        [Then(@"the reliability metric result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }

}
