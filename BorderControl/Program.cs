using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split();
            //List<ICitizen> citizens = new();
            List<IBorn> creatures = new();

            while (command[0] != "End")
            {
                if (command.Length == 5)
                {
                    creatures.Add(new Hooman(command[1], int.Parse(command[2]), command[3], command[4]));
                }
                else if (command.Length == 3)
                {
                    if (command[0] == "Pet")
                    {
                        creatures.Add(new Pet(command[1], command[2]));
                    }
                }
                command = Console.ReadLine().Split();
            }
            command = Console.ReadLine().Split();
            foreach (var creature in creatures)
            {
                if (creature.Birthdate.EndsWith(command[0]))
                {
                    Console.WriteLine(creature.Birthdate);
                }
            }

            //// BORDER CONTROL
            //while (command[0] != "End")
            //{
            //    if (command.Length == 3)
            //    {
            //        citizens.Add(new Hooman(command[0], int.Parse(command[1]), command[2]));
            //    }
            //    else
            //    {
            //        citizens.Add(new Robot(command[0], command[1]));
            //    }
            //    command = Console.ReadLine().Split();
            //}
            //command = Console.ReadLine().Split();
            //foreach (var citizen in citizens)
            //{
            //    if (citizen.Id.EndsWith(command[0]))
            //    {
            //        Console.WriteLine(citizen.Id);
            //    }
            //}
        }
    }
}
