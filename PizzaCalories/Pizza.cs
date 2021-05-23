namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }
        public string Name 
        {
            get
            {
                return name;
            }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int ToppingsCount => toppings.Count;
        public double TotalCalories => Calories();
        public Dough DoughType { get; set; }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                toppings.Add(topping);
            }
        }
        private double Calories()
        {
            double result = DoughType.CaloriesPerGram;
            foreach (Topping topping in toppings)
            {
                result += topping.CaloriesPerGram;
            }
            return result; 
        }
    }
}
