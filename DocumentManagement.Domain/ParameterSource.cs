namespace DocumentManagement.Domain
{
    public class ParameterSource
    {
        internal Guid ParameterSourceId { get; set; }
        internal string Endpoint { get; set; }
        internal bool AgreementReferenceRequired { get; set; }
        internal bool ProposalIdRequired { get; set; }
        
        internal ParameterSource(Guid parameterSourceId, string endpoint, bool agreementReferenceRequired, bool proposalIdRequired)
        {
            ParameterSourceId = parameterSourceId;
            Endpoint = endpoint;
            AgreementReferenceRequired = agreementReferenceRequired;
            ProposalIdRequired = proposalIdRequired;
        }
    }
}