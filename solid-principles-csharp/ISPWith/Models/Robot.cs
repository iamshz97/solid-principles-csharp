using ISPWith.Interfaces;

namespace ISPWith.Models;

public class Robot : IWorker, IRechargeable
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}