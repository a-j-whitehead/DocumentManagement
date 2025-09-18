using DocumentManagement.Domain.Documents;

namespace DocumentManagement.Domain.DocumentSender
{
    internal class EmailSender : IDocumentSender
    {
        public IEmailClient EmailClient { get; private set; }

        bool IDocumentSender.Send(BlueDocument document)
        {
            return EmailClient.SendEmail(new System.Net.Mail.MailMessage());
        }
    }
}