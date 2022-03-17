namespace Mvc1.Services.Email
{
    public class SendGridMailService:IMailService
    {
        private readonly SendGridMailService _mailService;

        public SendGridMailService(SendGridMailService mailService)
        {
            _mailService = mailService;
        }

        public DeliveryStatus SendMail(EmailMessage message)
        {
            //sendgrid ayarları
            return DeliveryStatus.Delivered;
        }
    }
}
