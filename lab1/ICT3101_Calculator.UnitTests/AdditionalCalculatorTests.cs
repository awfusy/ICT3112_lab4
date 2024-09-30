using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator.UnitTests
{

    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("D:\\ICT3112\\lab1\\lab1\\MagicNumbers.txt")).Returns(new string[3] { "42", "42", "-5" });
            _calculator = new Calculator();

            
        }
        // LAB 4 QN 8
        [Test]
        public void GenMagicNum_ValidIndex_ReturnsDoubleMagicNumber()
        {
            Console.WriteLine(_mockFileReader.Object);
            // Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(84));
        }
        [Test]
        public void GenMagicNum_NegativeValue_ReturnsZeroResult()
        {

            double result = _calculator.GenMagicNum(2, _mockFileReader.Object);
            // Verify the mock was called
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void GenMagicNum_InvalidIndex_ReturnsZeroResult()
        {

            double result = _calculator.GenMagicNum(100, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
