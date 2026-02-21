using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Infrastructure.Notifications;

public class EmailChannel : INotificationChannel
{
    public NotificationType Type => NotificationType.Email;

    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"Sending Email to: {message.Recipient}");
        Console.WriteLine($"Title: {message.Title}");
        Console.WriteLine($"Body: {message.Body}");
    }
}