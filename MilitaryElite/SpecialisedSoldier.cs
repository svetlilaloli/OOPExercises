namespace MilitaryElite
{
    using System;
    public abstract class SpecialisedSoldier : Private, IPrivate, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }
        public string Corps 
        {
            get
            {
                return corps;
            }
            private set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    corps = value;
                }
                else
                {
                    throw new ArgumentException("Invalid corps");
                }
            }
        }
    }
}
