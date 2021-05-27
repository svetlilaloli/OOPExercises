namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWork)
        {
            PartName = partName;
            Hours = hoursWork;
        }
        public string PartName { get; }

        public int Hours { get; private set; }
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {Hours}";
        }
    }
}
