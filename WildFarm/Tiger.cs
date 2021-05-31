namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }
        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "meat")
            {
                Weight += foodType.Quantity * 1.00;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }
        public override string MakeSound()
        {
            return "ROAR!!!";
        }
    }
}
