using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(';');
            List<Team> teams = new();
            Team team = new(line[1]);
            teams.Add(team);

            line = Console.ReadLine().Split(';');

            while (line[0] != "END")
            {
                try
                {
                    switch (line[0])
                    {
                        case "Team":
                            {
                                team = new(line[1]);
                                teams.Add(team);
                            }
                            break;
                        case "Add":
                            {
                                var found = FindTeam(teams, line[1]);
                                found.AddPlayer(new(line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7])));
                            }
                            break;
                        case "Remove":
                            {
                                var found = FindTeam(teams, line[1]);
                                found.RemovePlayer(line[2]);
                            }
                            break;
                        case "Rating":
                            {
                                var found = FindTeam(teams, line[1]);
                                PrintRating(found);
                            }
                            break;
                        default: break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                line = Console.ReadLine().Split(';');
            }
        }

        private static void PrintRating(Team team)
        {
            Console.WriteLine($"{team.Name} - {team.Rating}");
        }
        private static Team FindTeam(List<Team> teams, string name)
        {
            var found = teams.Find(t => t.Name == name);
            if (found != null)
            {
                return found;
            }
            else
            {
                throw new ArgumentException($"Team {name} does not exist.");
            }
        }
    }
}
