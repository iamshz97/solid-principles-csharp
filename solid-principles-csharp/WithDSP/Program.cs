using WithDSP.Interfaces;
using WithDSP.Services;

IMessageService messageService = new SMS();  // we can easily substitute this with new SMS()
NotificationService notification = new NotificationService(messageService);
notification.PromotionalNotification("+9471045876", "Hi");