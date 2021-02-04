using Calculater;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class CalculatorTest
    {
        private Calculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3.5,10,13.5)]
        [TestCase(1.7, 10, 11.7)]
        public void Test_Add2point3And6point7_expected9(double a, double b, double expected)
        {
          Assert.That(_uut.Add(a,b), Is.EqualTo(expected));
        }
        [Test]
        public void Test_Subtract8point3And6point2_expected9()
        {
            Assert.That(_uut.Subtract(8.3, 6.2), Is.EqualTo(2.1).Within(0.00001));
        }
        [Test]
        public void Test_Multiply8And2point5_expected20()
        {
            Assert.That(_uut.Multiply(8, 2.5), Is.EqualTo(20).Within(0.00001));
        }
        [Test]
        public void Test_Power2And5_expected20()
        {
            Assert.That(_uut.Power(2, 5), Is.EqualTo(32).Within(0.00001));
        }




    }
}