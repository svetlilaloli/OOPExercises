namespace CommandPattern
{
    public class HelloCommand : Command
    {
        public override string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
