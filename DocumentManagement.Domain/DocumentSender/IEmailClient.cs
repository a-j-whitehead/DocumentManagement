using System.Net.Mail;

namespace DocumentManagement.Domain.DocumentSender
{
    public interface IEmailClient
    {
        bool SendEmail(MailMessage mailMessage);
    }
}