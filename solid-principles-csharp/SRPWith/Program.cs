using Shared.Interfaces;
using Shared.Models;
using SRPWith.Interfaces;

ILogger logger = new FileErrorLogger();
IDataSaver datasaver = new ConsoleDataSaver();
EmployeeService employee = new EmployeeService(1, "John Doe", logger, datasaver);
employee.Add();

Console.ReadKey();