namespace DocumentManagement.Domain
{
    internal class TemplateVersion
    {
        internal Guid TemplateParameterId { get; set; }
        internal Guid TemplateId { get; }
        internal bool Active { get; set; }
        internal DateTime CreatedOn { get; set; }
        internal User CreatedBy { get; set; }

        internal TemplateVersion(Guid templateId)
        {
            TemplateId = templateId;
            TemplateParameterId = Guid.NewGuid();
        }
    }
}