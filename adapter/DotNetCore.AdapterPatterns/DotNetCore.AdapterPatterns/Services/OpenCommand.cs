namespace DotNetCore.AdapterPatterns.Services
{
    public class OpenCommand : ICommand
    {
        public string Execute()
        {
            return "Open image";
        }
    }
}
