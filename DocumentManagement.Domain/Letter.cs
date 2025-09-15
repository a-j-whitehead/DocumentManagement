namespace DocumentManagement.Domain
{
    internal class Letter
    {
        internal Guid LetterId { get; set; }
        internal Guid TemplateId { get; set; }
        internal Template Template { get; set; }
        internal DateTime? CreatedOn { get; set; }
        internal DateTime? SentOn { get; set; }
        internal string? AgreementReference { get; set; }
        internal int? ProposalId { get; set; }
        internal string? ErrorMessage { get; set; }

        internal void CreateAndSendLetter()
        {
            // Implementation for creating and sending a letter
        }
    }
}