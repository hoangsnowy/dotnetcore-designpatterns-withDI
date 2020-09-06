namespace DotNetCore.AdapterPatterns.Services
{
    public class ToolbarButton
    {
        private readonly ICommand _command;

        public ToolbarButton(ICommand command, string commandName)
        {
            _command = command;
            CommandName = commandName;
        }

        public string CommandName { get; }

        public string Click()
        {
            return _command.Execute();
        }
    }
}
