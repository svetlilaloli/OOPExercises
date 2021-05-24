using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private readonly Dictionary<string, int> skills;
        public Player(string name, params int[] stats)
        {
            Name = name;
            skills = new Dictionary<string, int>
            {
                { "Endurance", 0 },
                { "Sprint", 0 },
                { "Dribble", 0 },
                { "Passing", 0 },
                { "Shooting", 0 }
            };
            ValidateStats(stats);
            skills["Endurance"] = stats[0];
            skills["Sprint"] = stats[1];
            skills["Dribble"] = stats[2];
            skills["Passing"] = stats[3];
            skills["Shooting"] = stats[4];
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public double Stats => CalculateStats();
        private double CalculateStats()
        {
            int result = 0;
            foreach (var skill in skills)
            {
                result += skill.Value;
            }
            return Math.Round(result / (double)skills.Count);
        }
        private void ValidateStats(int[] stats)
        {
            for(int i = 0; i < stats.Length; i++)
            {
                if (stats[i] < 0 || stats[i] > 100)
                {
                    throw new ArgumentException($"{skills.ElementAt(i).Key} should be between 0 and 100.");
                }
            }
        }
    }
}
