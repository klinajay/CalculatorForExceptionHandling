using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    public class MathOperations
    {
        public void Factorial(int firstNumber)
        {
            int result = 1;
            
            for (int i = 1; i <= firstNumber; i++)
            {
                Console.WriteLine(result);
                result = result * i;
            }
            Console.WriteLine("The result of the factorial operation is: " + result);
        }
    }
}
