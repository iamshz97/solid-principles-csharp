using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithoutDSP.Models;

namespace WithoutDSP.Services;

public class NotificationService
{
    private EmailService _email;

    public NotificationService()
    {
        _email = new EmailService();
    }

    public void PromotionalNotification()
    {
        _email.SendEmail();
    }
}