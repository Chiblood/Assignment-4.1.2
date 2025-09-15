using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    public class Math : ICalculator
    {
        void Add(double a, double b)
        {
            return a + b;
        }
        void Subtract(double a, double b)
        {
            return a - b;
        }
        void Multiply(double a, double b)
        {
            return a * b;
        }
        void Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
