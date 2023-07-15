using ISPWithout.Interfaces;

namespace ISPWithout.Models;

public class Robot : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        // Robots don't eat, but we're forced to implement this method.
        throw new NotImplementedException();
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}