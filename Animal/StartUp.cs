﻿namespace Animal
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Animal cat = new Cat("Maria", "Whiskas");
            Animal dog = new Dog("Rex", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
