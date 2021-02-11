using System;
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
        [TestCase(5,0,5)]
        public void Test_Add_TestCase_aAddB_EqualsExpected(double a, double b, double expected)
        {
          Assert.That(_uut.Add(a,b), Is.EqualTo(expected));
        }

        [TestCase(8.3, 6.2, 2.1)]
        [TestCase(6, 3, 3)]
        [TestCase(5, 10, -5)]
        public void Test_Subtract_TestCase_aSubtractB_EqualsExpected(double a, double b, double expected)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(expected).Within(0.00001));
        }

        [TestCase(8, 2.5, 20)]
        [TestCase(4, -10, -40)]
        [TestCase(5, 0, 0)]
        public void Test_Multiply_TestCase_aMultiplyB_EqualsExpected(double a, double b, double expected)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(expected));
        }

        [TestCase(2, 5, 32)]
        [TestCase(4, 3, 64)]
        [TestCase(5, 2, 25)]
        public void Test_Power_TestCase_aPowerB_EqualsExpected(double a, double b, double expected)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(expected));
        }


        [TestCase(10, 2, 5)]
        [TestCase(6, 3, 2)]
        [TestCase(8, 4, 2)]
        public void Test_Divide_TestCase_aDEvideB_EqualsExpected(double a, double b, double expected)
        {
            Assert.That(_uut.Divide(a,b), Is.EqualTo(expected));
        }

        [Test]
        public void Test_Accumulator_Is_EqualTo_Multiply()
        {
            _uut.Add(2, 3);
            _uut.Multiply(3, 5);

            Assert.That(_uut.Accumulator, Is.EqualTo(15));
        }

        [Test]
        public void Test_Accumulator_Is_EqualTo_Add()
        {
            _uut.Multiply(3, 5);
            _uut.Add(2, 3);
            

            Assert.That(_uut.Accumulator, Is.EqualTo(5));
        }
        [Test]
        public void Test_Accumulator_Is_EqualTo_divide()
        {
            _uut.Multiply(3, 5);
            _uut.Divide(6, 3);


            Assert.That(_uut.Accumulator, Is.EqualTo(2));
        }

        [Test]
        public void Test_Divide_DivisorEquals0_ThrowException()
        {
            Assert.That(() => _uut.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());

        }



    }
}