using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Infrastructure.Notifications;

public class PushChannel : INotificationChannel
{
    public NotificationType Type => NotificationType.Push;

    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"Push Notification to: {message.Recipient}");
        Console.WriteLine($"Title: {message.Title}");
        Console.WriteLine($"Message: {message.Body}");
    }
}