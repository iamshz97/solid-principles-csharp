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