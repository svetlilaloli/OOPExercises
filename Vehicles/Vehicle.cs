namespace Vehicles
{
    using System;
    public abstract class Vehicle
    {
        private double fuelQuantity;
        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        }
        public double FuelQuantity 
        {
            get
            {
                return fuelQuantity;
            }
            protected set
            {
                if (value > TankCapacity)
                {
                    throw new ArgumentException($"Cannot fit {value - fuelQuantity} fuel in the tank");
                }
                fuelQuantity = value;
            }
        }
        public double FuelConsumption { get; protected set; }
        public int TankCapacity { get; protected set; }
        public abstract bool Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
