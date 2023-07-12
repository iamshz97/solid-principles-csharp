using WithDSP.Interfaces;

namespace WithDSP.Services;

public class NotificationService
{
    private IMessageService _message;

    public NotificationService(IMessageService message)
    {
        _message = message;
    }

    public void PromotionalNotification()
    {
        _message.SendMessage();
    }
}