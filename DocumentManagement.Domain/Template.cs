using DocumentManagement.Domain.Infrastructure;

namespace DocumentManagement.Domain
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

        internal Stream CreateDocumentFromTemplate(IS3Client s3Client, IBlueApiClient blueApiClient)
        {
            var templateBytes = s3Client.GetTemplate(this);

            var parameterSources = TemplateParameters
                .Select(tp => tp.Parameter.ParameterSource)
                .Distinct();

            var parameters = new List<LetterParameter>();
            foreach (var source in parameterSources)
            {
                parameters.AddRange(blueApiClient.GetLetterParameters(source));
            }

            foreach (var parameter in parameters)
            {
                //TODO - handle different parameter types (e.g. string, table, image)
            }

            throw new NotImplementedException("Document generation not implemented.");
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
    }
}
