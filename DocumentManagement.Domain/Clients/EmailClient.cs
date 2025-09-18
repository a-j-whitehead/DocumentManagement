using System.Net.Mail;

namespace DocumentManagement.Domain.Clients
{
    internal class EmailClient : IEmailClient
    {
        bool IEmailClient.SendEmail(MailMessage emailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
