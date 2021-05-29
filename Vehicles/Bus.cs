namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditioning = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity) { }
        public bool IsEmpty { get; internal set; }
        public override bool Drive(double distance)
        {
            var consumption = IsEmpty? distance * FuelConsumption : distance * (FuelConsumption + airConditioning);
            if (consumption <= FuelQuantity)
            {
                FuelQuantity -= consumption;
                return true;
            }
            return false;
        }
        public override void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
