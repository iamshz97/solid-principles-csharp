using WithDSP.Interfaces;

namespace WithDSP.Services;

public class SMS : IMessageService
{
    public void SendMessage()
    {
        // Code for sending SMS
        Console.WriteLine("SMS sent");
    }
}