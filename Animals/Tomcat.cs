namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
        }
        public override string Gender { get; set; } = "Male";
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
