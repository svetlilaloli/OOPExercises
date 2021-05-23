namespace PizzaCalories
{
    public abstract class Ingredient
    {
        internal const int baseCalories = 2;
        public abstract double CaloriesPerGram { get;}
        internal abstract int Weight { get; set; }
    }
}
