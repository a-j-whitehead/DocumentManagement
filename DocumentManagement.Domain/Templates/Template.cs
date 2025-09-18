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
