using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _fileReader;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_whenSubtractingOneZero()
        {
            double result = _calculator.Subtract(0, 10);
            Assert.That (result, Is.EqualTo(-10));
        }

        [Test]
        public void Multiply_whenMultiplyingOneZero()
        {
            double result = _calculator.Multiply(0, 10);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Divide(a, b), Is.EqualTo(double.PositiveInfinity));
        }
        [Test]
        public void Divide_ZerosByDinominator()
        {
            double result = _calculator.Divide(0, 5);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Factorial_WithNegativeAsInputs()
        {
            Assert.That(()=>_calculator.Factorial(-5),Throws.ArgumentException);
        }

        [Test]
        public void Factorial_InputFive_ReturnOneTwoZero()
        {
            // Act
            double result = _calculator.Factorial(5);

            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_InputAsOne_ReturnOne()
        {
            // Act
            double result = _calculator.Factorial(1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Factorial_InputAsZero_ReturnOne()
        {
            // Act
            double result = _calculator.Factorial(0);
            Assert.That(result, Is.EqualTo(1));
        }


        [Test]
        public void CalculateTriangleArea_InputHeightLength()
        {
            double result = _calculator.CalculateTriangleArea(10, 5);
            Assert.That(result, Is.EqualTo(25));
        }
        [Test]
        public void CalculateTrangileArea_InputNegativeHeight()
        {
            Assert.That(() => _calculator.CalculateTriangleArea(-5,5), Throws.ArgumentException);
        }

        [Test]
        public void CalculateTrangileArea_InputNegativeLength()
        {
            Assert.That(() => _calculator.CalculateTriangleArea(5, -5), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0,5)]
        [TestCase(5,0)]
        public void CalculateTrangileArea_InputZero(double num1, double num2)
        {
            Assert.That(() => _calculator.CalculateTriangleArea(num1,num2), Throws.ArgumentException);
        }

        [Test]
        public void CalculateCircleArea_InputRadius()
        {
            double result = _calculator.CalculateCircleArea(10);
            Assert.That(result, Is.EqualTo(Math.PI* 10 *10));
        }

        [Test]
        public void CalculateCircleArea_InputNegativeRadius()
        {
            Assert.That(() => _calculator.CalculateCircleArea(-2), Throws.ArgumentException);
        }

        [Test]
        public void CalculateCircleArea_InputZeroRadius()
        {
            Assert.That(() => _calculator.CalculateCircleArea(0), Throws.ArgumentException);
        }

        // 17 A
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        //17 b
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        /**
         [Test]
         public void Add_EmptyString_ReturnsZero()
         {
             // Arrange 
             var stringCalculator = new StringCalculator();

             // Act
             var actual = stringCalculator.Add("");

             // Assert
             Assert.Equals(0, actual);
         }
        **/



        // LAB 4 QN 8
        [Test]
        public void GenMagicNum_ValidIndex_ReturnsDoubleMagicNumber()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _fileReader); 
            // Assert
            Assert.That(result, Is.EqualTo(42));
        }
        [Test]
        public void GenMagicNum_NegativeValue_ReturnsZeroResult()
        {
            
            double result = _calculator.GenMagicNum(2, _fileReader);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void GenMagicNum_InvalidIndex_ReturnsZeroResult()
        {
            
            double result = _calculator.GenMagicNum(100, _fileReader);
            Assert.That(result, Is.EqualTo(0));
        }

       
    }
}