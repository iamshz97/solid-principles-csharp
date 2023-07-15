using Shared.Interfaces;

namespace OCPWith.Models;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    protected ILogger _logger;

    public Employee(int id, string name, ILogger logger)
    {
        Id = id;
        Name = name;
        _logger = logger;
    }

    public abstract void Add();
}

