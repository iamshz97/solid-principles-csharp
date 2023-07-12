using WithDSP.Interfaces;

namespace WithDSP.Services;

public class EmailService : IMessageService
{
    public void SendMessage()
    {
        // Code for sending email
        Console.WriteLine("Email sent");
    }
}