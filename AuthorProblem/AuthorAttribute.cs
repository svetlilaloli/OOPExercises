namespace AuthorProblem
{
    using System;
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
