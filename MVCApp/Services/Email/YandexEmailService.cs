using System.Diagnostics;

namespace MVCApp.Services.Email
{
    public class YandexEmailService : IMailService
    {
        public DeliveryStatus SendMail(EmailMessage message)
        {
            Debug.Write($"{message.Message}");
            return DeliveryStatus.Delivered;
        }
    }
}
