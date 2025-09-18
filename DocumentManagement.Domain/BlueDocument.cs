using DocumentManagement.Domain.Clients;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.DocumentSender;
using DocumentManagement.Domain.Templates;

namespace DocumentManagement.Domain
{
    public class BlueDocument
    {
        internal Guid LetterId { get; set; }
        internal Guid TemplateId { get; set; }
        internal Template Template { get; set; }
        internal SendMethod SendMethod { get; set; }
        internal IEnumerable<DocumentParameter>? LetterParameters { get; set; }
        internal DateTime? CreatedOn { get; set; }
        internal DateTime? SentOn { get; set; }
        internal string? AgreementReference { get; set; }
        internal int? ProposalId { get; set; }
        internal string? ErrorMessage { get; set; }

        internal BlueDocument()
        {
            LetterId = Guid.NewGuid();
        }

        internal void CreateAndSendLetter(
            IS3Client s3Client,
            BlueApiClient blueApiClient,
            IDocumentSender documentSender)
        {
            var document = Template.ConstructAndUploadDocument(s3Client, blueApiClient);

            documentSender.Send(document);
            documentSender.Send(this);
        }
    }
}