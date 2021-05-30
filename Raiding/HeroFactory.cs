namespace Raiding
{
    public abstract class HeroFactory
    {
        public HeroFactory(string name, int power)
        {
            Name = name;
            Power = power;
        }
        public string Name { get; protected set; }
        public int Power { get; protected set; }
        public abstract BaseHero GetHero();
    }
}
