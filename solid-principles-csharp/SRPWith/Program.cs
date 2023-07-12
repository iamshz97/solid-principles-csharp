using Shared.Interfaces;
using Shared.Models;

ILogger logger = new ErrorLogger();
Employee employee = new Employee(1, "John Doe", logger);
employee.Add();

Console.ReadKey();