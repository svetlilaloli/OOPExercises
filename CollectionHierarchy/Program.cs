namespace CollectionHierarchy
{
    using System;
    public class Program
    {
        public static void Main()
        {
            AddCollection addColl = new(100);
            AddRemoveCollection addRemoveColl = new(100);
            MyList myListColl = new(100);

            string[] line = Console.ReadLine().Split();
            int removes = int.Parse(Console.ReadLine());

            foreach (string item in line)
            {
                Console.Write($"{addColl.Add(item)} ");
            }
            Console.WriteLine();
            foreach (string item in line)
            {
                Console.Write($"{addRemoveColl.Add(item)} ");
            }
            Console.WriteLine();
            foreach (string item in line)
            {
                Console.Write($"{myListColl.Add(item)} ");
            }
            Console.WriteLine();
            for (int i = 0; i < removes; i ++)
            {
                Console.Write($"{addRemoveColl.Remove()} ");
            }
            Console.WriteLine();
            for (int i = 0; i < removes; i ++)
            {
                Console.Write($"{myListColl.Remove()} ");
            }
            Console.WriteLine();
        }
    }
}
