namespace DocumentManagement.Domain.DocumentSender
{
    internal class DocumentSender : IDocumentSender
    {
        private IEmailSender _emailSender;
        private IEveryMessageSender _everyMessageSender;
        
        internal DocumentSender(IEmailSender emailSender, IEveryMessageSender everyMessageSender)
        {
            _emailSender = emailSender;
            _everyMessageSender = everyMessageSender;
        }

        bool IDocumentSender.Send(BlueDocument document)
        {
            if (document.SendMethod == SendMethod.Email)
            {
                return _emailSender.SendViaEmail(document);
            }
            else if (document.SendMethod == SendMethod.EveryMessage)
            {
                return _everyMessageSender.SendViaEveryMessage(document);
            }
            else
            {
                // To implement other send methods:
                // 1. Create a new interface similar to IEmailSender and IEveryMessageSender
                // 2. Implement the interface in a new class
                // 3. Add a new parameter to the constructor of DocumentSender, and property
                // 4. Add a new condition here to call the new sender class
                throw new NotImplementedException("Unsupported send method");
            }
        }
    }
}
