namespace Car
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string colour, int battery)
        {
            Model = model;
            Colour = colour;
            Battery = battery;
        }
        public string Model { get;}
        public string Colour { get;}
        public int Battery { get;}

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
            return $"{Colour} Tesla {Model} with {Battery} Batteries";
        }
    }
}
