using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Domain.Abstractions;

public interface INotificationChannel
{
    string ChannelType { get; }


    void Send(NotificationMessage message);
}