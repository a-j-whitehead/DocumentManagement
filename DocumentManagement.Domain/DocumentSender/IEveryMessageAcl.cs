namespace DocumentManagement.Domain.DocumentSender
{
    internal class IEveryMessageAcl
    {
        internal static void SendViaEveryMessage(EveryMessageSender documentSender, Stream letterStream, string? agreementReference, int? proposalId)
        {
            throw new NotImplementedException();
        }
    }
}
