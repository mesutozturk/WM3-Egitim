namespace MVCApp.Services.Email
{
    public interface IMailService
    {
        DeliveryStatus SendMail(EmailMessage message);
    }
}
