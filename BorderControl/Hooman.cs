namespace BorderControl
{
    public class Hooman : ICitizen
    {
        public Hooman(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
    }
}
