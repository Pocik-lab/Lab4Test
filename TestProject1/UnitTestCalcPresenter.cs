using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLab4.Interfaces;
using TestLab4;

namespace TestProject1
{
    public class UnitTestCalcPresenter
    {
        class TestCalcView : ICalculatorView
        {
            public string Result { get; set; }
            public string Error { get; set; }
            public string FirstArg { get; set; }
            public string SecondArg { get; set; }
            public void PrintResult(double res)
            {
                Result = res.ToString("0.##");
            }
            public void DisplayError(string message)
            {
                Error = message;
            }

            public string GetFirstArgumentAsString()
            {
                return FirstArg;
            }

            public string GetSecondArgumentAsString()
            {
                return SecondArg;
            }
        }

        private ICalculatorPresenter calculatorPresenter;
        private TestCalcView calcView;

        [Fact]
        public void Setup()
        {
            calcView = new TestCalcView();
            calculatorPresenter = new CalculatorPresenter(calcView, new Calculator());
        }

        [Theory]
        [InlineData("1", "2", "3")]
        [InlineData("0.1", "0.2", "0.3")]
        [InlineData("-1", "-2", "-3")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "1")]
        [InlineData("1", "y", "1")]
        public void TestOnPlusClicked(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnPlusClicked();

            Assert.Equal(res, calcView.Result);
        }

        [Theory]
        [InlineData("1", "2", "-1")]
        [InlineData("-1", "-2", "1")]
        [InlineData("0.1", "0.2", "-0.1")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "-1")]
        [InlineData("1", "y", "1")]
        public void TestOnMinusClicked(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnMinusClicked();

            Assert.Equal(res, calcView.Result);
        }

        [Theory]
        [InlineData("1", "2", "2")]
        [InlineData("-1", "2", "-2")]
        [InlineData("-1", "-2", "2")]
        [InlineData("0.1", "0.2", "0.02")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "0")]
        [InlineData("1", "y", "0")]
        public void TestOnMultiplyClicked(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnMultiplyClicked();

            Assert.Equal(res, calcView.Result);
        }

        [Theory]
        [InlineData("2", "1", "2")]
        [InlineData("2", "-1", "-2")]
        [InlineData("0.02", "0.1", "0.2")]
        [InlineData("x", "y", null)]
        [InlineData("x", "1", "0")]
        [InlineData("1", "y", null)]
        public void TestOnDivideClicked(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnDivideClicked();

            Assert.Equal(res, calcView.Result);
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnPlusClickedThrowsException(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnPlusClicked();

            Assert.Equal(res, calcView.Error);
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnMinusClickedThrowsException(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnMinusClicked();

            Assert.Equal(res, calcView.Error);
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnMultiplyClickedThrowsException(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnMultiplyClicked();

            Assert.Equal(res, calcView.Error);
        }

        [Theory]
        [InlineData("1", "0", "Division by zero")]
        [InlineData("1", "0.00000001", "Division by zero")]
        [InlineData("1", "0.000000009", "Division by zero")]
        [InlineData("1", "-0.00000001", "Division by zero")]
        [InlineData("1", "-0.000000009", "Division by zero")]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnDivideClickedThrowsException(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnDivideClicked();

            Assert.Equal(res, calcView.Error);
        }

        [Theory]
        [InlineData("1", "0.000000011", "Division by zero")]
        [InlineData("1", "-0.000000011", "Division by zero")]
        public void TestOnDivideClickedNotThrowsException(string a, string b, string res)
        {
            Setup();
            calcView.FirstArg = a;
            calcView.SecondArg = b;

            calculatorPresenter.OnDivideClicked();

            Assert.NotEqual(res, calcView.Error);
        }
    }
}
