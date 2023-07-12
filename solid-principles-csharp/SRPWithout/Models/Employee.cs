﻿namespace SRPWithout.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
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
            //Saving error to a text file
            File.WriteAllText(@"C:\ErrorLog.txt", ex.ToString());
        }
    }
}
