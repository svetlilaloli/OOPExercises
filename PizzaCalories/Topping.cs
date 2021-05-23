namespace PizzaCalories
{
    using System;
    public class Topping : Ingredient
    {
        private int weight;
        internal Topping(string toppingType, int weight)
        {
            ToppingType = InstantiateType(toppingType);
            Weight = weight;
        }
        internal ToppingType ToppingType { get; }
        internal override int Weight
        {
            get
            { 
                return weight; 
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{ToppingType.GetType().Name} weight should be in the range [1..50].");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public override double CaloriesPerGram
        {
            get
            {
                return baseCalories * Weight * ToppingType.Calories;
            }
        }
        private static ToppingType InstantiateType(string toppingType)
        {
            return toppingType.ToLower() switch
            {
                "meat" => new Meat(),
                "cheese" => new Cheese(),
                "veggies" => new Veggies(),
                "sauce" => new Sauce(),
                _ => throw new ArgumentException($"Cannot place {toppingType} on top of your pizza."),
            };
        }
    }
}
