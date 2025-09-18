namespace DocumentManagement.Domain.DocumentSender
{
    internal interface IEmailSender
    {
        internal bool SendViaEmail(BlueDocument document);
    }
}