using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDSP.Interfaces;

namespace WithDSP.Services;

public class SMS : IMessageService
{
    public void SendMessage(string toContactInfo, string message)
    {
        // Code for sending SMS
        Console.WriteLine("SMS sent");
    }
}