namespace PizzaCalories
{
    internal class Cheese : ToppingType
    {
        private const double calories = 1.1;
        internal override double Calories => calories;
    }
}
