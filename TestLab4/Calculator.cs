using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLab4.Interfaces;

namespace TestLab4
{
    public class Calculator : ICalculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (Math.Abs(b) <= 0.00000001)
            {
                throw new ArithmeticException("Division by zero");
            }

            return a / b;
        }
    }
}
