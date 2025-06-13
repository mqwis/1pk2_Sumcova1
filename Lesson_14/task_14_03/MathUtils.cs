using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14_03
{
    class MathUtils
    {
        public static int Factorial(int number)
        {
            // Проверка на неотрицательное число
            if (number < 0)
            {
                throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            }

            // Вычисление факториала
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
