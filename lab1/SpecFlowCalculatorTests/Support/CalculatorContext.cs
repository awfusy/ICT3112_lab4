using ICT3101_Calculator;

namespace SpecFlowCalculatorTests.Support
{
    public class CalculatorContext
    {
        public double _result { get; set; }
        public Calculator _calculator { get; set; }
        public CalculatorContext()

        {
            _calculator = new Calculator();
        }
    }
}
