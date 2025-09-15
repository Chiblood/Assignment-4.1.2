/* Assignment 4.1.2
 2. Create an interface for ICalculator for methods like add, subtract, divide, multiply and implement them in a class: Math.

Use winforms to design a simple calculator with textboxes and buttons . Use the above designed interface in the calculator.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    public interface ICalculator
    {
        public void Add(double a, double b);
        public void Subtract(double a, double b);
        public void Multiply(double a, double b);
        public void Divide(double a, double b);
    }
}
