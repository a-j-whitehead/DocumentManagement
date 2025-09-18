namespace DocumentManagement.Domain.DocumentSender
{
    internal interface IDocumentSender
    {
        internal bool Send(BlueDocument document);
    }
}