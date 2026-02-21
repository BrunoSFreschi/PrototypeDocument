using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Infrastructure.Notifications;

public class WhatsAppChannel : INotificationChannel
{
    public NotificationType Type => NotificationType.WhatsApp;

    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"WhatsApp Message to: {message.Recipient}");
        Console.WriteLine($"Message: {message.Body}");
    }
}
