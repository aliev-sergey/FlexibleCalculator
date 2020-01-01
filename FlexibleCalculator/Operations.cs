namespace FlexibleCalculator
{
    public class OperationSub : ArithmeticOperationCommand
    {
        private ValueReciever _resultValue;
        private decimal[] _nums;

        public OperationSub(ValueReciever resultValue, params decimal[] nums)
        {

            _resultValue = resultValue;
            _nums = nums;
        }

        public void Calculate()
        {
            decimal subtrahend = _nums[0];
            for (int i = 1; i < _nums.Length; i++)
            {
                subtrahend -= _nums[i];
            }

            _resultValue.Value = subtrahend;
        }
    }

    public class OperationMul : ArithmeticOperationCommand
    {
        private ValueReciever _resultValue;
        private decimal[] _factors;

        public OperationMul(ValueReciever resultValue, params decimal[] factors)
        {
            _resultValue = resultValue;
            _factors = factors;
        }

        public void Calculate()
        {
            decimal composition = 1;

            foreach (decimal factor in _factors)
            {
                composition *= factor;
            }

            _resultValue.Value = composition;
        }
    }

    public class OperationSum : ArithmeticOperationCommand
    {
        private ValueReciever _resultValue;
        private decimal[] _addendums;

        public OperationSum(ValueReciever resultValue, params decimal[] addendums)
        {
            
            _resultValue = resultValue;
            _addendums = addendums;
        }

        public void Calculate()
        {
            decimal sum = 0;

            foreach (decimal addendum in _addendums)
            {
                sum += addendum;
            }

            _resultValue.Value = sum;
        }
    }

    public class OperationAbs : ArithmeticOperationCommand
    {
        private ValueReciever _resultValue;
        private decimal _num;

        public OperationAbs(ValueReciever resultValue, decimal num)
        {

            _resultValue = resultValue;
            _num = num;
        }

        public void Calculate()
        {
            _resultValue.Value = _num < 0 ? (_num * -1) : _num;
        }
    }
}
