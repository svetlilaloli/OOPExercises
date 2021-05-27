namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, IPrivate
    {
        private readonly List<Private> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, params Private[] privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new(privates);
        }
        public override string ToString()
        {
            StringBuilder result = new();
            result.Append($"{base.ToString()}\nPrivates:");
            foreach (Private prvt in privates)
            {
                result.Append($"\n\t{prvt}");
            }
            return result.ToString();
        }
    }
}
