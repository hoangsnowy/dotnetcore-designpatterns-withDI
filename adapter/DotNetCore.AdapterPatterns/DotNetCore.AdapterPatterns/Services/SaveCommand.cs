namespace DotNetCore.AdapterPatterns.Services
{
    public class SaveCommand : ICommand
    {
        public string Execute()
        {
            return "Save Image";
        }
    }
}
