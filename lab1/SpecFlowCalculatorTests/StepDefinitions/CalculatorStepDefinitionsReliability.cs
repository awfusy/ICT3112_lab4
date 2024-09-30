using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitionsReliability
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitionsReliability(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I entered (.*) failures in infinite time, (.*) initial failures and (.*) current failures")]
        public void WhenIEnteredFailureInInfiniteTimeAndInitialFailuresAndCurrentFailures(double failureInfinite, double initialFailures, double currentFailures)
        {
            _result = _calculator.FailureIntensity(failureInfinite, initialFailures, currentFailures);
        }
        [When(@"I entered (.*) failures in infinite time, (.*) initial failures and after (.*) cpu hours")]
        public void WhenIEnteredDecayParameterInitialFailureAndCpuHours(double failureInfinite, double initialFailures, double cpuHours)
        {
            _result = _calculator.AvgFailureIntensity(failureInfinite, initialFailures, cpuHours);
        }


        [Then(@"the reliability result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }
    }
}