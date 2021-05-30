namespace Raiding
{
    public class DruidFactory : HeroFactory
    {
        public DruidFactory(string name) : base(name, 80) { }

        public override BaseHero GetHero()
        {
            return new Druid(Name);
        }
    }
}
