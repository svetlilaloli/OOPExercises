namespace Animals
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            string animalType = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                try
                {
                    switch (animalType)
                    {
                        case "Dog": animals.Add(new Dog(name, age, gender)); break;
                        case "Cat": animals.Add(new Cat(name, age, gender)); break;
                        case "Frog": animals.Add(new Frog(name, age, gender)); break;
                        case "Kitten": animals.Add(new Kitten(name, age)); break;
                        case "Tomcat": animals.Add(new Tomcat(name, age)); break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animalType = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine($"{animal.ProduceSound()}");
            }
        }
    }
}