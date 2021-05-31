namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize) { }
        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "vegetable" || food == "meat" || food == "fruit" || food == "seeds")
            {
                Weight += foodType.Quantity * 0.35;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }
        public override string MakeSound()
        {
            return "Cluck";
        }
    }
}
