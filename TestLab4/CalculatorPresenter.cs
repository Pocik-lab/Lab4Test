using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLab4.Interfaces;

namespace TestLab4
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        private ICalculatorView calculatorView;
        private ICalculator calculator;

        public CalculatorPresenter(ICalculatorView calculatorView, ICalculator calculator)
        {
            this.calculatorView = calculatorView;
            this.calculator = calculator;
        }

        public void OnMultiplyClicked()
        {
            try
            {
                if (string.IsNullOrEmpty(calculatorView.GetFirstArgumentAsString()) ||
                    string.IsNullOrEmpty(calculatorView.GetSecondArgumentAsString()))
                {
                    throw new EmptyParamException();
                }
                double.TryParse(calculatorView.GetFirstArgumentAsString(), out double a);
                double.TryParse(calculatorView.GetSecondArgumentAsString(), out double b);
                calculatorView.PrintResult(calculator.Multiply(a, b));
            }
            catch (Exception exception)
            {
                calculatorView.DisplayError(exception.Message);
            }
        }

        public void OnDivideClicked()
        {
            try
            {
                if (string.IsNullOrEmpty(calculatorView.GetFirstArgumentAsString()) ||
                    string.IsNullOrEmpty(calculatorView.GetSecondArgumentAsString()))
                {
                    throw new EmptyParamException();
                }
                double.TryParse(calculatorView.GetFirstArgumentAsString(), out double a);
                double.TryParse(calculatorView.GetSecondArgumentAsString(), out double b);
                calculatorView.PrintResult(calculator.Divide(a, b));
            }
            catch (Exception exception)
            {
                calculatorView.DisplayError(exception.Message);
            }
        }

        public void OnMinusClicked()
        {
            try
            {
                if (string.IsNullOrEmpty(calculatorView.GetFirstArgumentAsString()) ||
                    string.IsNullOrEmpty(calculatorView.GetSecondArgumentAsString()))
                {
                    throw new EmptyParamException();
                }
                double.TryParse(calculatorView.GetFirstArgumentAsString(), out double a);
                double.TryParse(calculatorView.GetSecondArgumentAsString(), out double b);
                calculatorView.PrintResult(calculator.Subtract(a, b));
            }
            catch (Exception exception)
            {
                calculatorView.DisplayError(exception.Message);
            }
        }

        public void OnPlusClicked()
        {
            try
            {
                if (string.IsNullOrEmpty(calculatorView.GetFirstArgumentAsString()) ||
                    string.IsNullOrEmpty(calculatorView.GetSecondArgumentAsString()))
                {
                    throw new EmptyParamException();
                }
                double.TryParse(calculatorView.GetFirstArgumentAsString(), out double a);
                double.TryParse(calculatorView.GetSecondArgumentAsString(), out double b);
                calculatorView.PrintResult(calculator.Sum(a, b));
            }
            catch (Exception exception)
            {
                calculatorView.DisplayError(exception.Message);
            }
        }
    }
}
