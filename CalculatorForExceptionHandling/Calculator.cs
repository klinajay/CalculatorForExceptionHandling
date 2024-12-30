using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    internal class Calculator
    {
        double firstNumber;
        double secondNumber;
        string operation;
        public void TakeInput()
        {
            
            Console.WriteLine("Enter the operation you want to perform: ");
            operation = Console.ReadLine();
            checkOperationType();

        }
        public void TakeTwoNumbersInput()
        {
            Console.WriteLine("Enter the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
        }
        public void TakeSingleNumberInput()
        {
            Console.WriteLine("Enter the number: ");
             firstNumber = Convert.ToDouble(Console.ReadLine());
        }
        public void checkOperationType()
        {
            switch (operation)
            {
                case "+":
                    TakeTwoNumbersInput();
                    ArithmaticOperations additionOperation = new ArithmaticOperations();
                    additionOperation.Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    TakeTwoNumbersInput();
                    ArithmaticOperations subtractionOperation = new ArithmaticOperations();
                    subtractionOperation.Subtraction(firstNumber, secondNumber);
                    break;
                case "*":
                    TakeTwoNumbersInput();
                    ArithmaticOperations multiplicationOperation = new ArithmaticOperations();
                    multiplicationOperation.Multiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    TakeTwoNumbersInput();
                    ArithmaticOperations divisionOperation = new ArithmaticOperations();
                    divisionOperation.Division(firstNumber, secondNumber);
                    break;
                case "sin":
                    TakeSingleNumberInput();
                    TrigonometricOperations sinOperation = new TrigonometricOperations();
                    sinOperation.Sin(firstNumber);
                    break;
                case "cos":
                    TakeSingleNumberInput();
                    TrigonometricOperations cosOperation = new TrigonometricOperations();
                    cosOperation.Cos(firstNumber);
                    break;
                case "tan":
                    TakeSingleNumberInput();
                    TrigonometricOperations tanOperation = new TrigonometricOperations();
                    tanOperation.Tan(firstNumber);
                    break;
                case "factorial":
                    TakeSingleNumberInput();
                    MathOperations factorialoperation = new MathOperations();
                    Console.WriteLine((int) firstNumber);
                    factorialoperation.Factorial((int )firstNumber);
                    break;
                default:
                    Console.WriteLine("Invalid operation , Please enter a valid operation.");
                    break;
            }
        }
    }
}
