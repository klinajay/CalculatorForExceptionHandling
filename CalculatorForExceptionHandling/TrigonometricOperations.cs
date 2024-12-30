using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    public class TrigonometricOperations
    {
        public void Sin(double firstNumber)
        {
            double result = Math.Sin(firstNumber);
            Console.WriteLine("The result of the sin operation is: " + result);
        }
        public void Cos(double firstNumber)
        {
            double result = Math.Cos(firstNumber);
            Console.WriteLine("The result of the cos operation is: " + result);
        }
        public void Tan(double firstNumber)
        {
            double result = Math.Tan(firstNumber);
            Console.WriteLine("The result of the tan operation is: " + result);
        }
    }
}
