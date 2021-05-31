namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }
        public override bool Eats(Food foodType)
        {
            string food = foodType.GetType().Name.ToLower();
            if (food == "meat")
            {
                Weight += foodType.Quantity * 0.40;
                FoodEaten += foodType.Quantity;
                return true;
            }
            return false;
        }
        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
