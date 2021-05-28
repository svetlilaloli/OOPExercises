namespace ExplicitInterfaces
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();

            while (line[0] != "End")
            {
                Citizen citizen = new(line[0], line[1], int.Parse(line[2]));
                IPerson person = citizen;
                IResident resident = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                line = Console.ReadLine().Split();
            }
        }
    }
}
