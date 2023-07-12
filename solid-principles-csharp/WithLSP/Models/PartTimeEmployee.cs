namespace WithLSP.Models;

public class PartTimeEmployee : Employee
{
    public override string GetWorkDetails(int id)
    {
        return "PartTime Employee has less work";
    }

    public override string GetEmployeeDetails(int id)
    {
        return "PartTime Employee";
    }
}
