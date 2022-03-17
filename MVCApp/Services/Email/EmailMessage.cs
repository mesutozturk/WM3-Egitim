namespace MVCApp.Services.Email;

public class EmailMessage
{
    public string Message { get; set; }
    public string To { get; set; }
    public string Topic { get; set; }
    public byte[] Attach { get; set; }
}