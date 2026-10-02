using System;

namespace Calculator
{
    public class Class1
    {
        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитание двух чисел
        /// </summary>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение двух чисел
        /// </summary>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление двух чисел
        /// </summary>
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль невозможно!");
            }
            return a / b;
        }

        /// <summary>
        /// Возведение в степень
        /// </summary>
        public double Power(double a, double b)
        {
            // Проверка на отрицательное основание и дробную степень
            if (a < 0 && Math.Abs(b % 1) > double.Epsilon)
            {
                throw new ArgumentException("Ошибка: отрицательное основание и дробная степень не поддерживаются!");
            }

            // Проверка на ноль в нулевой степени
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Ошибка: ноль в нулевой степени не определено!");
            }

            return Math.Pow(a, b);
        }
    }
}