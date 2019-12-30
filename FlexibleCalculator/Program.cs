using System;

namespace FlexibleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueReciever reciever = new ValueReciever();
            Calculator calc = new Calculator();

            ArithmeticOperationCommand addition = new OperationSum(reciever, 5, 10, 15);
            calc.Operation = addition;
            calc.executeOperation();
            Console.WriteLine(reciever.Value);

            ArithmeticOperationCommand sub = new OperationSub(reciever, 20, 1, 15);
            calc.Operation = sub;
            calc.executeOperation();
            Console.WriteLine(reciever.Value);

            ArithmeticOperationCommand mul = new OperationMul(reciever, 5, 10, 15);
            calc.Operation = mul;
            calc.executeOperation();
            Console.WriteLine(reciever.Value);

            ArithmeticOperationCommand abs = new OperationAbs(reciever, -10);
            calc.Operation = abs;
            calc.executeOperation();
            Console.WriteLine(reciever.Value);

            Console.Read();
        }
    }
}
