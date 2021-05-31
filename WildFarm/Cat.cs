namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "vegetable" || food == "meat")
            {
                Weight += foodType.Quantity * 0.30;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
