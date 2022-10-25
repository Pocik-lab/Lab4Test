using System;
using TestLab4.Interfaces;
using TestLab4;

namespace TestProject1
{
    public class UnitTestCalc
    {
        private ICalculator calculator;
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(-1, 2, 1)]
        [InlineData(1, -2, -1)]
        [InlineData(1 / 3.0, 1 / 3.0, 2 / 3.0)]
        [InlineData(double.MinValue, double.MinValue, 2 * double.MinValue)]
        [InlineData(double.MaxValue, double.MaxValue, 2 * double.MaxValue)]
        public void TestSum(double a, double b, double res)
        {
            Setup();
            var ans = calculator.Sum(a, b);
            Assert.Equal(res, ans);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-1, -2, 1)]
        [InlineData(-1, 2, -3)]
        [InlineData(1, -2, 3)]
        [InlineData(2 / 3.0, 1 / 3.0, 1 / 3.0)]
        [InlineData(double.MinValue, double.MinValue, 0)]
        [InlineData(double.MaxValue, double.MaxValue, 0)]
        public void TestSubstract(double a, double b, double res)
        {
            Setup();
            var ans = calculator.Subtract(a, b);
            Assert.Equal(res, ans);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(-1, -2, 2)]
        [InlineData(-1, 2, -2)]
        [InlineData(1, -2, -2)]
        [InlineData(1 / 3.0, 2 / 3.0, 2 / 9.0)]
        [InlineData(double.MinValue, double.MinValue, double.MinValue * double.MinValue)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue * double.MaxValue)]
        public void TestMultiply(double a, double b, double res)
        {
            Setup();
            var ans = calculator.Multiply(a, b);
            Assert.Equal(res, ans);
        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(-1, -2, 0.5)]
        [InlineData(-1, 2, -0.5)]
        [InlineData(1, -2, -0.5)]
        [InlineData(2 / 3.0, 1 / 3.0, 2)]
        [InlineData(double.MinValue, double.MinValue, 1)]
        [InlineData(double.MaxValue, double.MaxValue, 1)]
        public void TestDivide(double a, double b, double res)
        {
            Setup();
            var ans = calculator.Divide(a, b);
            Assert.Equal(res, ans);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 0.00000001)]
        [InlineData(1, 0.000000009)]
        [InlineData(1, -0.00000001)]
        [InlineData(1, -0.000000009)]
        public void TestDivideThrowsException(double a, double b)
        {
            Setup();
            Assert.Throws<ArithmeticException>(() => calculator.Divide(a, b));
        }

        [Theory]
        [InlineData(1, 0.000000011)]
        [InlineData(1, -0.000000011)]
        public void TestDivideNotThrowsException(double a, double b)
        {
            Setup();
            var exception = Record.Exception(() => calculator.Divide(a, b));
            Assert.Null(exception);
        }
    }
}