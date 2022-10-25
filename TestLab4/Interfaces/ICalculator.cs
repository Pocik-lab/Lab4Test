using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab4.Interfaces
{
    public interface ICalculator
    {
        // Вычисляет сумму двух чисел
        double Sum(double a, double b);

        // Вычисляет разность двух чисел a - b
        double Subtract(double a, double b);

        // Вычисляет произведение двух чисел
        double Multiply(double a, double b);

        // Вычисляет отношение числа а к числу b.
        // Должен выбросить { ArithmeticException } если |b| < 10e-8
        double Divide(double a, double b);
    }
}
