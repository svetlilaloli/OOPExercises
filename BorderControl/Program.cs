using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split();
            List<ICitizen> citizens = new();

            while (command[0] != "End")
            {
                if (command.Length == 3)
                {
                    citizens.Add(new Hooman(command[0], int.Parse(command[1]), command[2]));
                }
                else
                {
                    citizens.Add(new Robot(command[0], command[1]));
                }
                command = Console.ReadLine().Split();
            }
            command = Console.ReadLine().Split();
            foreach (var citizen in citizens)
            {
                if (citizen.Id.EndsWith(command[0]))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
