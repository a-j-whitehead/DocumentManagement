using DocumentManagement.Domain.Clients.Dtos;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.Domain.Clients
{
    internal interface IBlueApiClient
    {
        internal IEnumerable<DocumentParameter> GetLetterParameters(ApiParameterSource parameterSouce);
        internal CustomerInformationDto GetCustomerInformation(string? agreementReference, int? proposalId);
    }
}