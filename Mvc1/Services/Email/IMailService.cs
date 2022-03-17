namespace Mvc1.Services.Email
{
    public interface IMailService
    {
        DeliveryStatus SendMail(EmailMessage message);
    }
}
