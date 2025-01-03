﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    public class ArithmaticOperations
    {
        public void Addition(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine("The result of the addition is: " + result);
        }
        public void Subtraction(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine("The result of the subtraction is: " + result);
        }
        public void Multiplication(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine("The result of the multiplication is: " + result);
        }
        //tried to avoid use of exception handling for division by zero
        public void Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                double result = firstNumber / secondNumber;
                Console.WriteLine("The result of the division is: " + result);
            }
        }
    }
}
