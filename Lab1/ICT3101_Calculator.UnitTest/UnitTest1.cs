namespace ICT3101_Caculator.UnitTest
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        FileReader getTheMagic;


        // Setup gets called before any test
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            getTheMagic = new FileReader();
        }

        // Naming Convention: MethodNameWe’reTesting_ScenarioWe’reTesting_ExpectedBehaviourOrResult
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtraction()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToMultiplication()
        {
            // Act
            double result = _calculator.Multiply(2, 3);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultEqualToDivison()
        {
            // Act
            double result = _calculator.Divide(6, 3);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(10, 0)]
        [TestCase(0, 10)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            // Assert
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        // Factorial Testing
        [Test]
        [TestCase(-10)]
        [TestCase(2.2)]
        public void Factorial_InputsLesserThanZeroOrDecimal_ResultThrowArgumentException(double a)
        {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WhenFactorizingNumbers_ResultIsOK()
        {
            // Act
            double result = _calculator.Factorial(3);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        // Shapes Testing
        [Test]
        public void Shapes_CalculateAreaOfTriangle_ResultIsOk()
        {
            // Act
            double result = _calculator.AreaOfTriangle(3, 2);
            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(-2, 2)]
        [TestCase(2, -3)]
        [TestCase(-4, -5)]
        [TestCase(0, 2)]
        public void CalculateTriangleArea_InputIsLesserThanOrEqualToZero_ResultThrowsArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Shapes_CalculateAreaOfCircle_ResultIsOkay()
        {
            //TEST 1
            // Act
            // double result = _calculator.AreaOfCircle(3);
            // Assert
            // Assert.That(result, Is.EqualTo(28.27));

            // TEST 2
            // Act
            double result = _calculator.AreaOfCircle(4);
            // Assert
            Assert.That(result, Is.EqualTo(50.27));
        }

        [Test]
        [TestCase(-2)]
        [TestCase(0)]
        public void CalculateCircleArea_InputIsLesserThanOrEqualToZero_ResultThrowsArgumentException(double a)
        {
            Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
        }

        // Unknown Function A Testings - 2 Factorial, 1 Divide, 1 Subtract

        // 5! = 120
        // 3! = 6
        //  
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

        // Functional B - 3 Factorial, 1 Divide, 1 Multiply, 1 Subtract
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
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void GenMagicNum_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.GenMagicNum(3, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void GenMagicNum_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.GenMagicNum(2, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
        //[Test]
        //[TestCase(-1)]
        //[TestCase(-5)]
        //public void GenMagicNum_InputIsNegative_ResultThrowsArgumentException(int a)
        //{
        //    // Act
        //    // Assert
        //    Assert.That(() => _calculator.GenMagicNum(a), Throws.ArgumentException);
        //}
    }
}