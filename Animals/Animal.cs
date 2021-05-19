namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            if (age < 0)
            {
                throw new System.Exception("Invalid input!");
            }
            else
            {
                Age = age;
            }
            Gender = gender;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public virtual string Gender { get; set; }
        public virtual string ProduceSound()
        {
            return default;
        }
    }
}
