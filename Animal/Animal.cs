namespace Animal
{
    public class Animal
    {
        protected Animal(string name, string favFood)
        {
            Name = name;
            FavouriteFood = favFood;
        }
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
