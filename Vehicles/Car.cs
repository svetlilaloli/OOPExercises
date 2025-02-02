﻿namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditioning = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
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
        }
    }
}
