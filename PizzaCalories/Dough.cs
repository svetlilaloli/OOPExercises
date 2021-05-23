namespace PizzaCalories
{
    using System;
    public class Dough : Ingredient
    {
        private int weight;
        internal Dough(string flourType, string baking, int weight)
        {
            FlourType = InstantiateFlour(flourType);
            Baking = InstantiateBakingTechnique(baking);
            Weight = weight;
        }
        internal Flour FlourType { get; }
        internal BakingTechnique Baking { get; }
        internal override int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
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
                return baseCalories * Weight * FlourType.Calories * Baking.Calories;
            }
        }
        private static Flour InstantiateFlour(string type)
        {
            if (type.ToLower() == "white")
            {
                return new White();
            }
            else if (type.ToLower() == "wholegrain")
            {
                return new Wholegrain();
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
        private static BakingTechnique InstantiateBakingTechnique(string baking)
        {
            if (baking.ToLower() == "crispy")
            {
                return new Crispy();
            }
            else if (baking.ToLower() == "chewy")
            {
                return new Chewy();
            }
            else if (baking.ToLower() == "homemade")
            {
                return new Homemade();
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
    }
}
