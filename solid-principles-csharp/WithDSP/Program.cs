using WithDSP.Interfaces;
using WithDSP.Services;

IMessage messageService = new EmailService();  // we can easily substitute this with new SMS()
NotificationService notification = new NotificationService(messageService);
notification.PromotionalNotification();