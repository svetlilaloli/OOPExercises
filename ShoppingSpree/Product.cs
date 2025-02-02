﻿namespace ShoppingSpree
{
    using System;
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
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
        public decimal Price
        {
            get 
            { 
                return price; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                else
                {
                    price = value;
                }
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
