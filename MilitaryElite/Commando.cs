namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ISpecialisedSoldier
    {
        private readonly List<Mission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, params Mission[] missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new(missions);
        }
        public override string ToString()
        {
            StringBuilder result = new();
            result.Append($"{base.ToString()}\nCorps: {Corps}\nMissions:");
            foreach (Mission mission in missions)
            {
                result.Append($"\n\t{mission}");
            }
            return result.ToString();
        }
    }
}
