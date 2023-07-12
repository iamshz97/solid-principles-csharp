using WithLSP.Models;

Employee partTimeEmployee = new PartTimeEmployee();
Console.WriteLine(partTimeEmployee.GetWorkDetails(123));
Console.WriteLine(partTimeEmployee.GetEmployeeDetails(123));

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
Console.WriteLine(fullTimeEmployee.GetWorkDetails(123));
Console.WriteLine(fullTimeEmployee.GetEmployeeDetails(123));
Console.WriteLine(fullTimeEmployee.CalculateBonus(10000));