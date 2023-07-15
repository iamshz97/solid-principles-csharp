using Shared.Interfaces;

namespace Shared.Models;

public class FileErrorLogger : ILogger
{
    public void Log(string errorMessage)
    {
        File.WriteAllText("C:/Error", errorMessage);
    }
}
