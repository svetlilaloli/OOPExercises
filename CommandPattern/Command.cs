namespace CommandPattern
{
    public abstract class Command : ICommand
    {
        public abstract string Execute(string[] args);
    }
}
