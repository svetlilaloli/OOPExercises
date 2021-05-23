namespace PizzaCalories
{
    internal class Meat : ToppingType
    {
        private const double calories = 1.2;
        internal override double Calories => calories;
    }
}
