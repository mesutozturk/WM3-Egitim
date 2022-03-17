using System.Diagnostics;

namespace Mvc1.Services.Email
{
    public class GoogleMailService:IMailService
    {
        public DeliveryStatus SendMail(EmailMessage message)
        {
            Debug.Write($"Google: {message.Message}");
            return DeliveryStatus.Delivered;
        }
    }
}
