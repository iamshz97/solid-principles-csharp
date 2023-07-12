using ISPWithout.Interfaces;

namespace ISPWithout.Models;

public class Manager : IWork
{
    public void Manage()
    {
        //manager specific actions
    }

    public void StartEat()
    {
        throw new NotImplementedException();
    }

    public void StartWork()
    {
        throw new NotImplementedException();
    }

    public void StopEat()
    {
        throw new NotImplementedException();
    }

    public void StopWork()
    {
        throw new NotImplementedException();
    }
}