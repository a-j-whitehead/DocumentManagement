using DocumentManagement.Domain.AntiCorruptionLayers;
using DocumentManagement.Domain.Clients;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.DocumentSender;
using DocumentManagement.Domain.Templates;

namespace DocumentManagement.Domain.Documents
{
    internal class BlueDocument
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

        internal void CreateAndSendLetter(S3Client s3Client, BlueApiAcl blueApiClient, EveryMessageSender documentSender)
        {
            using var templateStream = s3Client.DownloadTemplate(Template);
            using var letterStream = CreateDocumentFromTemplate(templateStream, blueApiClient);

            s3Client.UploadLetterStream(Template, letterStream);

            if (SendMethod == SendMethod.EveryMessage)
            {
                EveryMessageSender.Send()
                IEveryMessageAcl.SendViaEveryMessage(documentSender, letterStream, AgreementReference, ProposalId);
            }
            else if (SendMethod == SendMethod.Email)
            {
                EmailSender.Send();
            }
        }

        internal Stream CreateDocumentFromTemplate(Stream templateStream, BlueApiAcl blueApiClient)
        {
            var parameterSources = Template.TemplateParameters
                .Select(tp => tp.Parameter.ParameterSource)
                .Distinct();

            var parameters = new List<DocumentParameter>();
            foreach (var source in parameterSources)
            {
                parameters.AddRange(blueApiClient.GetLetterParameters(source));
            }
            LetterParameters = parameters;

            return AsposeParameterReader.ApplyParametersToDocument(templateStream, parameters);
        }
    }
}