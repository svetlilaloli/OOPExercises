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
                double km = double.Parse(line[2]);

                if (line[0] == "Drive")
                {
                    if (line[1] == "Car")
                    {
                        if (car.Drive(km))
                        {
                            Console.WriteLine($"Car travelled {km} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (line[1] == "Truck")
                    {
                        if (truck.Drive(km))
                        {
                            Console.WriteLine($"Truck travelled {km} km");
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
                        car.Refuel(km);
                    }
                    else if (line[1] == "Truck")
                    {
                        truck.Refuel(km);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f}");
        }
    }
}
