namespace FlexibleCalculator
{
    class Calculator
    {
        public ArithmeticOperation Operation { private get; set; }
        public Calculator(ArithmeticOperation operation)
        {
            Operation = operation;
        }
        public decimal executeOperation(decimal firstOperand, decimal secondOperand) => Operation.DoOperation(firstOperand, secondOperand);
    }
}
