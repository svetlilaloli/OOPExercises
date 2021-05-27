namespace MilitaryElite
{
    using System;
    public class Mission : IMission
    {
        private string state;
        public Mission(string codeName, string state)
        {
            State = state;
            CodeName = codeName;
        }
        public string CodeName { get; }

        public string State 
        {
            get
            {
                return state;
            }
            private set
            {
                if (value == "Finished" || value == "inProgress")
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentException("Invalid mission");
                }
            }
        }

        public void CompleteMission()
        {
            State = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
