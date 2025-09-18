using System.Net.Mail;

namespace DocumentManagement.Domain.Clients
{
    internal interface IEmailClient // TODO - rename this to IEmailAcl?
    {
        internal bool SendEmail(MailMessage mailMessage);
    }
}