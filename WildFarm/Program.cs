namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            int i = 0;
            string[] command = Console.ReadLine().Split();
            Animal animal = null;
            Food food = null;
            List<Animal> animals = new();

            while (command[0] != "End")
            {
                if (i % 2 == 0)
                {
                    switch (command[0].ToLower())
                    {
                        case "owl": animal = new Owl(command[1], double.Parse(command[2]), double.Parse(command[3])); break;
                        case "hen": animal = new Hen(command[1], double.Parse(command[2]), double.Parse(command[3])); break;
                        case "cat": animal = new Cat(command[1], double.Parse(command[2]), command[3], command[4]); break;
                        case "tiger": animal = new Tiger(command[1], double.Parse(command[2]), command[3], command[4]); break;
                        case "mouse": animal = new Mouse(command[1], double.Parse(command[2]), command[3]); break;
                        case "dog": animal = new Dog(command[1], double.Parse(command[2]), command[3]); break;
                        default:
                            break;
                    }
                    Console.WriteLine(animal.MakeSound());
                    animals.Add(animal);
                }
                else
                {
                    switch (command[0].ToLower())
                    {
                        case "vegetable": food = new Vegetable(int.Parse(command[1])); break;
                        case "fruit": food = new Fruit(int.Parse(command[1])); break;
                        case "meat": food = new Meat(int.Parse(command[1])); break;
                        case "seeds": food = new Seeds(int.Parse(command[1])); break;
                        default:
                            break;
                    }

                    bool feed = animal.Eats(food);
                    if (!feed)
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                }

                i++;
                command = Console.ReadLine().Split();
            }
            foreach (Animal animal1 in animals)
            {
                Console.WriteLine(animal1);
            }
        }
    }
}
