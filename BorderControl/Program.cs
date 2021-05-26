using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        public static void Main()
        {
            // FOOD SHORTAGE
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                if (line.Length == 4)
                {
                    buyers.Add(new Citizen(line[0], int.Parse(line[1]), line[2], line[3]));
                }
                else if (line.Length == 3)
                {
                    buyers.Add(new Rebel(line[0], int.Parse(line[1]), line[2]));
                }
            }
            string name = Console.ReadLine();
            while (name != "End")
            {
                var buyer = buyers.Find(b => b.Name == name);
                if (buyer != null)
                {
                    buyer.BuyFood();
                }
                name = Console.ReadLine();
            }
            Console.WriteLine(buyers.Sum(b => b.Food));

            //// BIRTHDAY CELEBRATIONS
            //string[] command = Console.ReadLine().Split();
            ////List<ICitizen> citizens = new();
            //List<IBorn> creatures = new();

            //while (command[0] != "End")
            //{
            //    if (command.Length == 5)
            //    {
            //        creatures.Add(new Citizen(command[1], int.Parse(command[2]), command[3], command[4]));
            //    }
            //    else if (command.Length == 3)
            //    {
            //        if (command[0] == "Pet")
            //        {
            //            creatures.Add(new Pet(command[1], command[2]));
            //        }
            //    }
            //    command = Console.ReadLine().Split();
            //}
            //command = Console.ReadLine().Split();
            //foreach (var creature in creatures)
            //{
            //    if (creature.Birthdate.EndsWith(command[0]))
            //    {
            //        Console.WriteLine(creature.Birthdate);
            //    }
            //}

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
