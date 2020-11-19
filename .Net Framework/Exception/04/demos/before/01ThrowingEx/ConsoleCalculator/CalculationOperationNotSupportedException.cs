
using System;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation {get;}

        public CalculationOperationNotSupportedException():
            base("Specified operation was out of the range of valid values.")
        {
                
        }
        public CalculationOperationNotSupportedException(string operation)
            : this()
        {
            Operation = operation;
        }
        public CalculationOperationNotSupportedException(string operation, string message):
            base(message)
        {
            Operation = operation;
        }
        public override string Message
        {
            get 
            {
                string message = base.Message;
                if (Operation != null) 
                {
                    return message + Environment.NewLine + $" Unsupported operation: {Operation}";
                }
                return message;
            }
        }
    }
}
