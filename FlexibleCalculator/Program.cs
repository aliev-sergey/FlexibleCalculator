using System;

namespace FlexibleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstOperand = 256;
            decimal secondOperand = 4;

            Calculator calculator = new Calculator(new OperationAdd());
            Console.WriteLine($"{firstOperand} + {secondOperand} = {calculator.executeOperation(firstOperand, secondOperand)}");

            calculator.Operation = new OperationMul();
            Console.WriteLine($"{firstOperand} * {secondOperand} = {calculator.executeOperation(firstOperand, secondOperand)}");

            calculator.Operation = new OperationSub();
            Console.WriteLine($"{firstOperand} - {secondOperand} = {calculator.executeOperation(firstOperand, secondOperand)}");

            calculator.Operation = new OperationDiv();
            Console.WriteLine($"{firstOperand} / {secondOperand} = {calculator.executeOperation(firstOperand, secondOperand)}");

            calculator.Operation = new OperationPow();
            Console.WriteLine($"{firstOperand} ^ {secondOperand} = {calculator.executeOperation(firstOperand, secondOperand)}");

            Console.Read();
        }
    }
}
