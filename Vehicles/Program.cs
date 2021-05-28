namespace Vehicles
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();
            Car car = new(double.Parse(line[1]), double.Parse(line[2]));
            line = Console.ReadLine().Split();
            Truck truck = new(double.Parse(line[1]), double.Parse(line[2]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                if (line[0] == "Drive")
                {
                    if (line[1] == "Car")
                    {
                        if (car.Drive(double.Parse(line[2])))
                        {
                            Console.WriteLine($"Car travelled {double.Parse(line[2])} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (line[1] == "Truck")
                    {
                        if (truck.Drive(double.Parse(line[2])))
                        {
                            Console.WriteLine($"Truck travelled {double.Parse(line[2])} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else if (line[0] == "Refuel")
                {
                    if (line[1] == "Car")
                    {
                        car.Refuel(double.Parse(line[2]));
                    }
                    else if (line[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(line[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f}");
        }
    }
}
