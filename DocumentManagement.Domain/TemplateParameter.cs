namespace DocumentManagement.Domain
{
    internal class TemplateParameter
    {
        internal Guid TemplateParameterId { get; set; }
        internal Guid TemplateVersionId { get; }
        internal TemplateVersion TemplateVersion { get; }
        internal Guid ParameterId { get; }
        internal ParameterSchema Parameter { get; }

        internal TemplateParameter(Guid templateVersionId, Guid parameterId)
        {
            TemplateParameterId = Guid.NewGuid();
            TemplateVersionId = templateVersionId;
            ParameterId = parameterId;
        }
    }
}