using Shared.Interfaces;

namespace OCPWithout.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmployeeType { get; set; }

    private ILogger _logger;

    public Employee(int id, string name, string employeeType, ILogger logger)
    {
        Id = id;
        Name = name;
        EmployeeType = employeeType;
        _logger = logger;
    }

    public void Add()
    {
        try
        {
            if (EmployeeType == "Regular")
            {
                // Logic for adding the regular employee to the database
                Console.WriteLine($"Regular employee {Name} with id {Id} added to the database.");
            }
            else if (EmployeeType == "Contractor")
            {
                // Logic for adding the contractor to the database
                Console.WriteLine($"Contractor {Name} with id {Id} added to the database.");
            }
        }
        catch (Exception ex)
        {
            _logger.Log(ex.ToString());
        }
    }
}