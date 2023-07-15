using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutLSP.Models;

public abstract class Employee
{
    public virtual string GetWorkDetails(int id)
    {
        return "Base Work";
    }

    public virtual string GetEmployeeDetails(int id)
    {
        return "Base Employee";
    }

    public abstract decimal CalculateBonus(decimal salary);
}