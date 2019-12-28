using System;

namespace FlexibleCalculator
{
    public class OperationAdd : ArithmeticOperation
    {
        public decimal DoOperation(decimal firstOperand, decimal secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }

    public class OperationSub : ArithmeticOperation
    {
        public decimal DoOperation(decimal firstOperand, decimal secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }

    public class OperationMul : ArithmeticOperation
    {
        public decimal DoOperation(decimal firstOperand, decimal secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }

    public class OperationDiv : ArithmeticOperation
    {
        public decimal DoOperation(decimal firstOperand, decimal secondOperand)
        {
            if (secondOperand == 0)
            {
                throw new DivideByZeroException();
            }
            return firstOperand / secondOperand;
        }
    }

    public class OperationPow : ArithmeticOperation
    {
        public decimal DoOperation(decimal firstOperand, decimal exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            if (exponent % 2 == 1)
            {
                return DoOperation(firstOperand, exponent - 1) * firstOperand;
            }
            else
            {
                decimal result = DoOperation(firstOperand, exponent / 2);
                return result * result;
            }
        }
    }
}
