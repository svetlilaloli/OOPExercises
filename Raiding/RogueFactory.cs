namespace Raiding
{
    public class RogueFactory : HeroFactory
    {
        public RogueFactory(string name) : base(name, 80) { }
        public override BaseHero GetHero()
        {
            return new Rogue(Name);
        }
    }
}
