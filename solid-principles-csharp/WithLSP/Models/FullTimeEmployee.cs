namespace WithLSP.Models;

public class FullTimeEmployee : Employee
{
    public override string GetWorkDetails(int id)
    {
        return "FullTime Employee has more work";
    }

    public override string GetEmployeeDetails(int id)
    {
        return "FullTime Employee";
    }

    public decimal CalculateBonus(decimal salary)
    {
        return salary * 0.25M;
    }
}