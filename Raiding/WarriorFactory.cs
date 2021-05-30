namespace Raiding
{
    public class WarriorFactory : HeroFactory
    {
        public WarriorFactory(string name) : base(name, 100) { }

        public override BaseHero GetHero()
        {
            return new Warrior(Name);
        }
    }
}
