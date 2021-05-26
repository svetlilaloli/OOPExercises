namespace BorderControl
{
    public class Citizen : ICitizen, IBorn, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }
        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
