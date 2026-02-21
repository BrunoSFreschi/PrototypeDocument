using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Domain.Abstractions;

public interface INotificationChannel
{
    NotificationType Type { get; }
    void Send(NotificationMessage message);
}