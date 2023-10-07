using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    // класс Class1 наследует класс MarshalByRefObject
    public class Class1 : MarshalByRefObject
    {
        // функция вычисления квадратного уравнения
        public bool CalcEquation(double a, double b, double c, out double x1, out double x2)
        {
            double d; // дискриминант
                      // Решение квадратного уравнения
                      // вычисление дискриминанта
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                return true;
            }
            else
            if (d == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                return true;
            }
            else
            {
                x1 = x2 = 0;
                return false;
            }
        }
    }

}