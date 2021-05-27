using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();
            List<Private> privates = new();

            while (line[0] != "End")
            {
                switch (line[0].ToLower())
                {
                    case "private":
                        {
                            Private prvt = new(int.Parse(line[1]), line[2], line[3], decimal.Parse(line[4]));
                            privates.Add(prvt);
                            Console.WriteLine(prvt);
                        }
                        break;
                    case "lieutenantgeneral":
                        {
                            List<Private> myPrivates = new();
                            for (int i = 5; i < line.Length; i++)
                            {
                                int id = int.Parse(line[i]);
                                myPrivates.Add(privates.Find(p => p.Id == id));
                            }
                            LieutenantGeneral gnrl = new(int.Parse(line[1]), line[2], line[3], decimal.Parse(line[4]),
                                myPrivates.ToArray());
                            Console.WriteLine(gnrl);
                        }
                        break;
                    case "engineer":
                        try
                        {
                            List<Repair> myRepairs = new();
                            for (int i = 6; i < line.Length - 1; i += 2)
                            {
                                myRepairs.Add(new(line[i], int.Parse(line[i + 1])));
                            }
                            Engineer eng = new(int.Parse(line[1]), line[2], line[3], decimal.Parse(line[4]),
                                line[5], myRepairs.ToArray());
                            Console.WriteLine(eng);
                        }
                        catch (ArgumentException)
                        {
                            break;
                        }
                        break;
                    case "commando":
                        try
                        {
                            List<Mission> myMissions = new();
                            for (int i = 6; i < line.Length - 1; i += 2)
                            {
                                try
                                {
                                    myMissions.Add(new(line[i], line[i + 1]));
                                }
                                catch (ArgumentException)
                                {
                                    continue;
                                }
                            }
                            Commando cmmd = new(int.Parse(line[1]), line[2], line[3], decimal.Parse(line[4]),
                                line[5], myMissions.ToArray());
                            Console.WriteLine(cmmd);
                        }
                        catch (ArgumentException)
                        {
                            break;
                        }
                        break;
                    case "spy":
                        {
                            Spy spy = new(int.Parse(line[1]), line[2], line[3], int.Parse(line[4]));
                            Console.WriteLine(spy);
                        }
                        break;
                    default:
                        break;
                }
                line = Console.ReadLine().Split();
            }
        }
    }
}
