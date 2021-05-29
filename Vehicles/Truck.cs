namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditioning = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity) { }
        public override bool Drive(double distance)
        {
            var consumption = distance * (FuelConsumption + airConditioning);
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
            FuelQuantity -= liters * 5 / 100;
        }
    }
}
