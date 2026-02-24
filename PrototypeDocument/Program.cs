using Microsoft.Extensions.DependencyInjection;
using PrototypeDocument.Domain.Abstractions;
using PrototypeDocument.Domain.Enums;
using PrototypeDocument.Infrastructure.Notifications;

var services = new ServiceCollection();

services.AddSingleton<INotificationChannel, EmailChannel>();
services.AddSingleton<INotificationChannel, SmsChannel>();
services.AddSingleton<INotificationChannel, PushChannel>();
services.AddSingleton<INotificationChannel, WhatsAppChannel>();

services.AddSingleton<NotificationManager>();

var provider = services.BuildServiceProvider();
var manager = provider.GetRequiredService<NotificationManager>();

manager.SendOrderConfirmation("cliente@email.com", "12345", NotificationType.Email);
Console.WriteLine();
manager.SendOrderConfirmation("+5511999999999", "12346", NotificationType.Sms);
Console.WriteLine();
manager.SendShippingUpdate("device-token-abc", "BR123456789", NotificationType.Push);