namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion) { }
        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "vegetable" || food == "fruit")
            {
                Weight += foodType.Quantity * 0.10;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }
        public override string MakeSound()
        {
            return "Squeak";
        }
    }
}
