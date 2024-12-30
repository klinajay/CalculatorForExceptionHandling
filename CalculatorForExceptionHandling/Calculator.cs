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
        int integerNumber;
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
            try
            {
                if (operation == "factorial")
                {
                    Console.WriteLine("Enter the integer number: ");
                    if (int.TryParse(Console.ReadLine(), out integerNumber))
                    {
                        firstNumber = integerNumber;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer number");
                        throw new FormatException("Invalid input for factorial operation");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the number: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                
                throw;
            }

        }
        public void checkOperationType()
        {
            try
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
                        Console.WriteLine((int)firstNumber);
                        factorialoperation.Factorial((int)firstNumber);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(operation);

                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Incorrect operation enterd: " + ex.ParamName);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }
    }
}