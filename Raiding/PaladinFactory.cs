namespace Raiding
{
    public class PaladinFactory : HeroFactory
    {
        public PaladinFactory(string name) : base(name, 100) { }
        public override BaseHero GetHero()
        {
            return new Paladin(Name);
        }
    }
}
