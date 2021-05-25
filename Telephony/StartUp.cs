using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] webSites = Console.ReadLine().Split();

            CallNumbers(phoneNumbers);
            OpenWebsites(webSites);
        }

        private static void OpenWebsites(string[] webSites)
        {
            foreach (string site in webSites)
            {
                bool isInvalid = false;
                for (int i = 0; i < site.Length; i++)
                {
                    if (char.IsDigit(site[i]))
                    {
                        Console.WriteLine("Invalid URL!");
                        isInvalid = true;
                        break;
                    }
                }
                if (!isInvalid)
                {
                    Console.WriteLine(new Smartphone().Browse(site));
                }
            }
        }

        private static void CallNumbers(string[] phoneNumbers)
        {
            foreach (string num in phoneNumbers)
            {
                bool isInvalid = false;
                for (int i = 0; i < num.Length; i++)
                {
                    if (!char.IsDigit(num[i]))
                    {
                        Console.WriteLine("Invalid number!");
                        isInvalid = true;
                        break;
                    }
                }
                if (!isInvalid)
                {
                    if (num.Length == 10)
                    {
                        Console.WriteLine(new Smartphone().Call(num));
                    }
                    else
                    {
                        Console.WriteLine(new StationaryPhone().Call(num));
                    }
                }
            }
        }
    }
}
