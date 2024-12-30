using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    public class Calculator
    {
        double firstNumber;
        double secondNumber;
        int integerNumber;
        string operation;
        bool isExceptionOccured = false;
        public  Calculator(double firstNumber , double secondNumber , string operation)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.operation = operation;
            
        }
        public  Calculator()
        {
            this.firstNumber = double.NaN;
            this.secondNumber = double.NaN;
            this.operation = null;
            
        }
        public void Calculate()
        {
            checkOperationType();

        }
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
                        if(firstNumber == double.NaN || secondNumber == double.NaN)
                        {
                            TakeTwoNumbersInput();
                        }
                        
                        ArithmaticOperations additionOperation = new ArithmaticOperations();
                        additionOperation.Addition(firstNumber, secondNumber);
                        break;
                    case "-":
                        if (firstNumber == double.NaN || secondNumber == double.NaN)
                        {
                            TakeTwoNumbersInput();
                        }

                        ArithmaticOperations subtractionOperation = new ArithmaticOperations();
                        subtractionOperation.Subtraction(firstNumber, secondNumber);
                        break;
                    case "*":
                        if (firstNumber == double.NaN || secondNumber == double.NaN)
                        {
                            TakeTwoNumbersInput();
                        }

                        ArithmaticOperations multiplicationOperation = new ArithmaticOperations();
                        multiplicationOperation.Multiplication(firstNumber, secondNumber);
                        break;
                    case "/":
                        if (firstNumber == double.NaN || secondNumber == double.NaN)
                        {
                            TakeTwoNumbersInput();
                        }

                        ArithmaticOperations divisionOperation = new ArithmaticOperations();
                        divisionOperation.Division(firstNumber, secondNumber);
                        break;
                    case "sin":
                        if (firstNumber == double.NaN )
                        {
                            TakeSingleNumberInput();
                        }

                        TrigonometricOperations sinOperation = new TrigonometricOperations();
                        sinOperation.Sin(firstNumber);
                        break;
                    case "cos":
                        if (firstNumber == double.NaN)
                        {
                            TakeSingleNumberInput();
                        }

                        TrigonometricOperations cosOperation = new TrigonometricOperations();
                        cosOperation.Cos(firstNumber);
                        break;
                    case "tan":
                        if (firstNumber == double.NaN)
                        {
                            TakeSingleNumberInput();
                        }

                        TrigonometricOperations tanOperation = new TrigonometricOperations();
                        tanOperation.Tan(firstNumber);
                        break;
                    case "factorial":
                        if (firstNumber == double.NaN)
                        {
                            TakeSingleNumberInput();
                        }

                        MathOperations factorialoperation = new MathOperations();
                        Console.WriteLine((int)firstNumber);
                        factorialoperation.Factorial((int)firstNumber);
                        break;
                    default:
                        throw new OperationNotValidException(operation);

                }
            }
            catch (OperationNotValidException ex)
            {
                isExceptionOccured = true;
                Console.WriteLine(ex.ToString());
                throw;
            }
            catch (FormatException ex)
            {
                isExceptionOccured = true;
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                isExceptionOccured = true;
                Console.WriteLine("An error occured: " + ex.Message);
            }
            finally
            {
                if (!isExceptionOccured)
                {
                    Console.WriteLine("The operation is completed");
                }
                else
                {
                    Console.WriteLine("The operation could not completed");
                }
            }
        }
    }
}