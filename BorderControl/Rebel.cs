﻿namespace BorderControl
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public string Name { get; }
        public int Age { get; }
        public string Group { get; set; }
        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
