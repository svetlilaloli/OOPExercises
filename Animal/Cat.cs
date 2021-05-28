namespace Animal
{
    public class Cat : Animal
    {
        public Cat(string name, string favFood) : base (name, favFood) { }
        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nMEEOW";
        }
    }
}
