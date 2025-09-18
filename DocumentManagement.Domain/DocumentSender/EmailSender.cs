using DocumentManagement.Domain.Clients;
using System.Net.Mail;

namespace DocumentManagement.Domain.DocumentSender
{
    internal class EmailSender : IEmailSender
    {
        private readonly IEmailClient _emailClient;
        
        internal EmailSender(IEmailClient emailClient)
        {
            _emailClient = emailClient;
        }

        bool IEmailSender.SendViaEmail(BlueDocument document)
        {
            var mailMessage = ConstructMailMessage(document);
            return _emailClient.SendEmail(mailMessage);
        }

        private static MailMessage ConstructMailMessage(BlueDocument document)
        {
            throw new NotImplementedException();
        }
    }
}