using ISPWith.Interfaces;

namespace ISPWith.Models;

public class Worker : IWork, IEat
{
    public void StartWork()
    {
        //Worker specific actions
    }

    public void StopWork()
    {
        //Worker specific actions
    }

    public void StartEat()
    {
        //Worker specific actions
    }

    public void StopEat()
    {
        //Worker specific actions
    }
}
