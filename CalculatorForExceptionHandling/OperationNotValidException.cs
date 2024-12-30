using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForExceptionHandling
{
    internal class OperationNotValidException : CalculatorException
    {
        public const string defaultMessage = "The operation is not valid";
        public string Operation { get; }
        public OperationNotValidException() : base(defaultMessage)
        {
            
        }
        
        public OperationNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public OperationNotValidException(Exception innerException) : base(defaultMessage , innerException)
        {
            
        }
        public OperationNotValidException(string operation) : base(defaultMessage) => Operation = operation;
        public OperationNotValidException(string operation, string message) : base(message) => Operation = operation;
        public override string ToString()
        {
            if(Operation == null)
            {
                return base.ToString();
            }
            else
            {
                return base.ToString()+Environment.NewLine +"Not Supported operation: " +Operation;
            }
        }

    }
}
