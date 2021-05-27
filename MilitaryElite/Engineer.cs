namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, ISpecialisedSoldier
    {
        private readonly List<Repair> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, params Repair[] repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new(repairs);
        }
        public override string ToString()
        {
            StringBuilder result = new();
            result.Append($"{base.ToString()}\nCorps: {Corps}\nRepairs:");
            foreach (Repair repair in repairs)
            {
                result.Append($"\n\t{repair}");
            }
            return result.ToString();
        }
    }
}
