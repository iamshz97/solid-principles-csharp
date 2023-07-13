using ISPWithout.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPWithout.Models;

public class OfficeWorker : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}
