﻿namespace WildFarm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; protected set; }
    }
}
