namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    public class Person
    {
        private readonly List<Product> bag;
        private string name;
        private decimal money;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }
        public string Name 
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public decimal Money {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                {
                    money = value;
                }
            }
        }
        public List<Product> Bag => bag;
        public void AddToBag(Product product)
        {
            if (product.Price <= Money)
            {
                bag.Add(product);
                Money -= product.Price;
            }
            else
            {
                throw new Exception("Not enough money");
            }
        }
    }
}
