namespace Raiding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            HeroFactory factory = null;
            List<BaseHero> heroes = new();

            int n = int.Parse(Console.ReadLine());
            
            while(heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type.ToLower())
                {
                    case "druid":
                        factory = new DruidFactory(name);
                        break;
                    case "paladin":
                        factory = new PaladinFactory(name);
                        break;
                    case "rogue":
                        factory = new RogueFactory(name);
                        break;
                    case "warrior":
                        factory = new WarriorFactory(name);
                        break;
                    default: Console.WriteLine("Invalid hero!");
                        break;
                }

                if (factory != null)
                {
                    BaseHero baseHero = factory.GetHero();
                    heroes.Add(baseHero);
                }
            }

            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            int bossPower = int.Parse(Console.ReadLine());
            int sumPower = heroes.Sum(h => h.Power);

            if (sumPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
