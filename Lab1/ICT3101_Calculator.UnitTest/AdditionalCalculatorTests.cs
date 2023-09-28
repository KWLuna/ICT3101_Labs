using Moq;

namespace ICT3101_Calculator.UnitTest
{
    class AdditionalCalculatorTests
    {

        private Calculator _calculator;
        Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();

            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[5] { "42", "42", "23", "2", "5" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.GenMagicNum(4, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void GenMagicNum_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(84));
        }
    }
}
