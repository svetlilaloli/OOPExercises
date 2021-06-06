namespace CommandPattern
{
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split();

            if (input[0] == "Hello")
            {
                return new HelloCommand().Execute(input.Skip(1).ToArray());
            }
            else if (input[0] == "Exit")
            {
                return new ExitCommand().Execute(input.Skip(1).ToArray());
            }
            return null;
        }
    }
}
