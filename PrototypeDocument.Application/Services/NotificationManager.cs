using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Models;

namespace PrototypeDocument.Application.Services;

public class NotificationManager
{
    private readonly Dictionary<string, INotificationChannel> _channels;

    public NotificationManager(IEnumerable<INotificationChannel> channels)
    {
        _channels = channels.ToDictionary(c => c.ChannelType, c => c);
    }

    private INotificationChannel Resolve(string type)
    {
        if (!_channels.TryGetValue(type.ToLower(), out var channel))
            throw new ArgumentException($"Canal '{type}' não suportado");

        return channel;
    }

    public void SendOrderConfirmation(string recipient, string orderNumber, string notificationType)
    {
        var message = new NotificationMessage
        {
            Recipient = recipient,
            Title = "Confirmação de Pedido",
            Body = $"Seu pedido {orderNumber} foi confirmado!"
        };

        Resolve(notificationType).Send(message);
    }

    public void SendShippingUpdate(string recipient, string trackingCode, string notificationType)
    {
        var message = new NotificationMessage
        {
            Recipient = recipient,
            Title = "Pedido Enviado",
            Body = $"Rastreamento: {trackingCode}"
        };

        Resolve(notificationType).Send(message);
    }

    public void SendPaymentReminder(string recipient, decimal amount, string notificationType)
    {
        var message = new NotificationMessage
        {
            Recipient = recipient,
            Title = "Lembrete de Pagamento",
            Body = $"Pagamento pendente: R$ {amount:N2}"
        };

        Resolve(notificationType).Send(message);
    }
}