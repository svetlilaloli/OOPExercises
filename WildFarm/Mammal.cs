﻿namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
        public string LivingRegion { get; protected set; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
