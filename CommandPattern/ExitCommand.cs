namespace CommandPattern
{
    using System;
    public class ExitCommand : Command
    {
        public override string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
