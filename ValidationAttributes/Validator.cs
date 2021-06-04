namespace ValidationAttributes
{
    using System.Reflection;
    using System;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            bool result = true;
            Type type = obj.GetType();
            var props = type.GetProperties();

            foreach (var prop in props)
            {
                var requiredAttribute = prop.GetCustomAttribute<MyRequiredAttribute>();
                var rangeAttribute = prop.GetCustomAttribute<MyRangeAttribute>();

                if (requiredAttribute != null)
                {
                    if (!requiredAttribute.IsValid(obj))
                    {
                        result = false;
                        break;
                    }
                }
                if (rangeAttribute != null)
                {
                    if (!rangeAttribute.IsValid(obj))
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
