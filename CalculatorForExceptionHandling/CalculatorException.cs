using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    internal class CalculatorException : Exception
    {
        public static string defaultMessage = "An error occured in the calculator application";
        public CalculatorException() : base(defaultMessage)
        {
        }
        public CalculatorException(string message) : base(message)
        {
        }
        public CalculatorException(string message , Exception innerException): base(message , innerException)
        {

        }
        public CalculatorException( Exception innerException) : base(defaultMessage, innerException)
        {

        }
    }
}
