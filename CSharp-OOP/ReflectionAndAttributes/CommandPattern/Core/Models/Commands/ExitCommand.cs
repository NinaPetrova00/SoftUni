namespace CommandPattern.Core.Models.Commands
{
    using Core.Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return null;
        }
    }
}
