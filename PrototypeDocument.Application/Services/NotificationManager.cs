using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Application.Services;

public class NotificationManager
{
    private readonly Dictionary<NotificationType, INotificationChannel> _channels;

    public NotificationManager(IEnumerable<INotificationChannel> channels)
    {
        _channels = channels.ToDictionary(c => c.Type, c => c);
    }

    private INotificationChannel Resolve(NotificationType type)
    {
        if (!_channels.TryGetValue(type, out var channel))
            throw new InvalidOperationException($"Canal {type} não registrado");

        return channel;
    }

    public void SendOrderConfirmation(string recipient, string orderNumber, NotificationType type)
    {
        var message = new NotificationMessage
        {
            Recipient = recipient,
            Title = "Confirmação de Pedido",
            Body = $"Seu pedido {orderNumber} foi confirmado!"
        };

        Resolve(type).Send(message);
    }

    public void SendShippingUpdate(string recipient, string trackingCode, NotificationType type)
    {
        var message = new NotificationMessage
        {
            Recipient = recipient,
            Title = "Pedido Enviado",
            Body = $"Rastreamento: {trackingCode}"
        };

        Resolve(type).Send(message);
    }
}