using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab4.Interfaces
{
    public interface ICalculatorView
    {
        // Отображает результат вычисления
        void PrintResult(double result);

        // Показывает ошибку, например деление на 0, пустые аргументы и прочее
        void DisplayError(String message);

        // Возвращает значение, введенное в поле первого аргументы
        string GetFirstArgumentAsString();

        // Возвращает значение, введенное в поле второго аргументы
        string GetSecondArgumentAsString();
    }
}
