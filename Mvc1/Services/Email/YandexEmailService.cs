using System.Diagnostics;

namespace Mvc1.Services.Email
{
    public class YandexEmailService : IMailService
    {
        public DeliveryStatus SendMail(EmailMessage message)
        {
            Debug.Write($"Yandex: {message.Message}");
            return DeliveryStatus.Delivered;
        }
    }
}
