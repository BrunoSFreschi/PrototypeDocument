using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Infrastructure.Notifications;

public class SmsChannel : INotificationChannel
{
    public NotificationType Type => NotificationType.Sms;

    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"SMS to: {message.Recipient}");
        Console.WriteLine($"Message: {message.Body}");
    }
}
