namespace DocumentManagement.Domain.DocumentSender
{
    internal interface IEveryMessageSender
    {
        internal bool SendViaEveryMessage(BlueDocument document);
    }
}