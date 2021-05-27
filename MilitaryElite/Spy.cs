namespace MilitaryElite
{
    public class Spy : Soldier, ISoldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public int CodeNumber { get; }
        public override string ToString()
        {
            return $"{base.ToString()}\nCode Number: {CodeNumber}";
        }
    }
}
