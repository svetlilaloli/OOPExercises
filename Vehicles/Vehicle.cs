namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public abstract double FuelQuantity { get; protected set; }
        public abstract double FuelConsumption { get; protected set; }
        public abstract bool Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
