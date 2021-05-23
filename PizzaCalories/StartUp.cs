namespace PizzaCalories
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] line = Console.ReadLine().Split();
                Pizza pizza = new(line[1]);
                line = Console.ReadLine().Split();
                Dough dough = new(line[1], line[2], int.Parse(line[3]));
                pizza.DoughType = dough;
                line = Console.ReadLine().Split();

                while (line[0] != "END")
                {
                    if (line[0].ToLower() == "topping")
                    {
                        pizza.AddTopping(new(line[1], int.Parse(line[2])));
                    }

                    line = Console.ReadLine().Split();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
