namespace FlexibleCalculator
{
    class Calculator
    {
        public ArithmeticOperationCommand Operation { private get; set; }
        public void executeOperation() => Operation.Calculate();
    }
}
