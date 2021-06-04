namespace ValidationAttributes
{
    using System;
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            bool result;
            Type objType = obj.GetType();
            var ageProp = objType.GetProperty("Age");
            var agePropValue = (int)ageProp.GetValue(obj);
            if (agePropValue >= minValue && agePropValue <= maxValue)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}

