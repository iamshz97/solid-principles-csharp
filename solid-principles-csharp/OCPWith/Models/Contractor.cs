using Shared.Interfaces;

namespace OCPWith.Models;

public class Contractor : Employee
{
    public Contractor(int id, string name, ILogger logger) : base(id, name, logger)
    {
    }

    public override void Add()
    {
        try
        {
            // Logic for adding the contractor to the database
            Console.WriteLine($"Contractor {Name} with id {Id} added to the database.");
        }
        catch (Exception ex)
        {
            _logger.Log(ex.ToString());
        }
    }
}