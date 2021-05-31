using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] fields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static 
                | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder result = new();
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            result.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => fields.Contains(f.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return result.ToString().Trim();
        }
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder result = new();
            foreach (FieldInfo field in classFields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} have to be private!");
            }
            return result.ToString().Trim();
        }
    }
}
