namespace Car
{
    public interface ICar
    {
        public string Model { get;}
        public string Colour { get;}
        public string Start();
        public string Stop();
    }
}
