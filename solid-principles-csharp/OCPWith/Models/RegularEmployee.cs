using Shared.Interfaces;

namespace OCPWith.Models;

public class RegularEmployee : Employee
{
    public RegularEmployee(int id, string name, ILogger logger) : base(id, name, logger)
    {
    }

    public override void Add()
    {
        try
        {
            // Logic for adding the regular employee to the database
            Console.WriteLine($"Regular employee {Name} with id {Id} added to the database.");
        }
        catch (Exception ex)
        {
            _logger.Log(ex.ToString());
        }
    }
}