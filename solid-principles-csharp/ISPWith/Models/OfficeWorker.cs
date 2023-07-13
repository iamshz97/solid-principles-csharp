using ISPWith.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPWith.Models;

public class OfficeWorker : IWorker, IEater, IRechargeable
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