namespace Car
{
    public class Seat : ICar
    {
        public Seat(string model, string colour)
        {
            Model = model;
            Colour = colour;
        }
        public string Model { get; }
        public string Colour { get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Colour} Seat {Model}";
        }
    }
}
