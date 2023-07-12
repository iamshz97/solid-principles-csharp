
using Shared.Interfaces;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    private ILogger _logger;

    public Employee(int id, string name, ILogger logger)
    {
        Id = id;
        Name = name;
        _logger = logger;
    }

    public void Add()
    {
        try
        {
            // Logic for adding the employee to the database
            Console.WriteLine($"Employee {Name} with id {Id} added to the database.");
        }
        catch (Exception ex)
        {
            _logger.Log(ex.ToString());
        }
    }
}