using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDSP.Interfaces;

namespace WithDSP.Services;

public class NotificationService
{
    private IMessageService _messageService;

    public NotificationService(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void PromotionalNotification(string toContactInfo, string message)
    {
        _messageService.SendMessage(toContactInfo, message);
    }
}