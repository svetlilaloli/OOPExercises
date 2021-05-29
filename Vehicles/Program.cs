namespace Vehicles
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();
            Car car = new(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));
            line = Console.ReadLine().Split();
            Truck truck = new(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));
            line = Console.ReadLine().Split();
            Bus bus = new(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                
                double amount = double.Parse(line[2]);

                if (line[0] == "Drive" || line[0] == "DriveEmpty")
                {
                    if (line[1] == "Car")
                    {
                        if (car.Drive(amount))
                        {
                            Console.WriteLine($"Car travelled {amount} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (line[1] == "Truck")
                    {
                        if (truck.Drive(amount))
                        {
                            Console.WriteLine($"Truck travelled {amount} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                    else
                    {
                        if (line[0] == "DriveEmpty")
                        {
                            bus.IsEmpty = true;
                        }
                        else
                        {
                            bus.IsEmpty = false;
                        }
                        if (bus.Drive(amount))
                        {
                            Console.WriteLine($"Bus travelled {amount} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                }
                else if (line[0] == "Refuel")
                {
                    if (amount <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                        continue;
                    }
                    try
                    {
                        if (line[1] == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (line[1] == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else
                        {
                            bus.Refuel(amount);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f}");
        }
    }
}
