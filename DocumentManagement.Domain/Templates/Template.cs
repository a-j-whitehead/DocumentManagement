using DocumentManagement.Domain.Clients;
using DocumentManagement.Domain.DocumentParameters;

namespace DocumentManagement.Domain.Templates
{
    public class Template
    {
        public Guid TemplateId { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal IEnumerable<TemplateVersion> TemplateVersions { get; set; }
        internal IEnumerable<TemplateParameter> TemplateParameters { get; set; }
        internal DateTime CreatedOn { get; set; }
        internal User CreatedBy { get; set; }

        internal Template(string name, string description, User createdBy)
        {
            TemplateId = Guid.NewGuid();
            Name = name;
            Description = description;
            TemplateVersions = [];
            CreatedOn = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        internal BlueDocument ConstructAndUploadDocument(IS3Client s3Client, BlueApiClient blueApiClient)
        {
            // TODO - catch exceptions, return null doc on exception?
            using var templateStream = s3Client.DownloadTemplate(this);
            using var letterStream = CreateDocumentFromTemplate(templateStream, blueApiClient);

            s3Client.UploadTemplate(this);

            return new BlueDocument();
        }

        internal void ActivateTemplateVersion(Guid templateVersionId)
        {
            if (!TemplateVersions.Any(tv => tv.TemplateParameterId == templateVersionId))
            {
                // TODO - add custom exceptions?
                throw new InvalidOperationException("Template version not found.");
            }

            TemplateVersions.Single(tv => tv.Active).Active = false;
            TemplateVersions.Single(tv => tv.TemplateParameterId == templateVersionId).Active = true;
        }

        internal Stream GetStreamFromS3(IS3Client s3Client)
        {
            return s3Client.DownloadTemplate(this);
        }

        private Stream CreateDocumentFromTemplate(Stream templateStream, IBlueApiClient blueApiClient)
        {
            var parameterSources = TemplateParameters
                .Select(tp => tp.Parameter.ParameterSource)
                .Distinct();

            var parameters = new List<DocumentParameter>();
            foreach (var source in parameterSources)
            {
                parameters.AddRange(blueApiClient.GetLetterParameters(source));
            }

            return AsposeParameterReader.ApplyParametersToDocument(templateStream, parameters);
        }
    }
}
