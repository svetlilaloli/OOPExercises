namespace Stealer
{
    using System;
    public class Program
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);
            result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
            result = spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
