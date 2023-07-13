using OCPWithout.Models;
using Shared.Interfaces;
using Shared.Models;

ILogger logger = new FileErrorLogger();

Employee employee = new Employee(1, "John Doe", "Regular", logger);
employee.Add();

Employee contractor = new Employee(2, "Jane Doe", "Contractor", logger);
contractor.Add();

Console.ReadKey();