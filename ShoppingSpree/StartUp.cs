namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            string[] line1 = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            string[] line2 = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string command = Console.ReadLine();

            try
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    var currentPerson = line1[i].Split('=');
                    Person person = new Person(currentPerson[0], decimal.Parse(currentPerson[1]));
                    people.Add(person);
                }
                for (int i = 0; i < line2.Length; i++)
                {
                    var currentProduct = line2[i].Split('=');
                    Product product = new Product(currentProduct[0], decimal.Parse(currentProduct[1]));
                    products.Add(product);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            while (command != "END")
            {
                var currentCommand = command.Split();
                try
                {
                    people.Find(n => n.Name == currentCommand[0]).AddToBag(products.Find(p => p.Name == currentCommand[1]));
                    Console.WriteLine($"{currentCommand[0]} bought {currentCommand[1]}");
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Not enough money")
                    {
                        Console.WriteLine($"{currentCommand[0]} can\'t afford {currentCommand[1]}");
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (Person person in people)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
