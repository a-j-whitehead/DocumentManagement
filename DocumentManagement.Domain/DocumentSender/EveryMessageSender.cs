namespace DocumentManagement.Domain.DocumentSender
{
    internal class EveryMessageSender : IEveryMessageSender
    {
        bool IEveryMessageSender.SendViaEveryMessage(BlueDocument document)
        {
            throw new NotImplementedException();
        }
    }
}