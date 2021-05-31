namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize) { }
        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "meat")
            {
                Weight += foodType.Quantity * 0.25;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }
        public override string MakeSound()
        {
            return "Hoot Hoot";
        }
    }
}
