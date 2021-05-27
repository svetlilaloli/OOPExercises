﻿namespace MilitaryElite
{
    public class Private : Soldier, ISoldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }
        public decimal Salary { get; private set; }
        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Salary:f2}";
        }
    }
}
