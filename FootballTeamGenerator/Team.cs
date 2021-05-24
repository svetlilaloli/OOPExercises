using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        public int NumberOfPlayers => players.Count;

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
        
        public int Rating => CalculateRating();

        private int CalculateRating()
        {
            double result = 0;
            if (players.Count > 0)
            {
                foreach (Player player in players)
                {
                    result += player.Stats;
                }
                return (int)(result / players.Count);
            }
            return (int)result;
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public bool RemovePlayer(string name)
        {
            if(players.Remove(players.Find(p => p.Name == name)))
            {
                return true;
            }
            else
            {
                throw new Exception($"Player {name} is not in {Name} team.");
            }
        }
    }
}
