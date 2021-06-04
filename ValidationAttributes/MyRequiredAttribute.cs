using System;
namespace ValidationAttributes
{
    using System;
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            bool result;
            Type objType = obj.GetType();
            var nameProp = objType.GetProperty("FullName");
            var namePropValue = nameProp.GetValue(obj);
            if (namePropValue == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
