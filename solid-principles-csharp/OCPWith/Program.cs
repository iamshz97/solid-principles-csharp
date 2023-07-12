using OCPWith.Models;
using Shared.Interfaces;
using Shared.Models;

ILogger logger = new ErrorLogger();

Employee employee = new RegularEmployee(1, "John Doe", logger);
employee.Add();

Employee contractor = new Contractor(2, "Jane Doe", logger);
contractor.Add();

Console.ReadKey();

