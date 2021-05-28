namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditioning = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption) { }
        public override double FuelQuantity { get; protected set; }
        public override double FuelConsumption { get; protected set; }

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
        }
    }
}
