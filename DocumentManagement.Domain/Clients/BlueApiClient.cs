using DocumentManagement.Domain.Clients.Dtos;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.Domain.Clients
{
    internal class BlueApiClient : IBlueApiClient
    {
        CustomerInformationDto IBlueApiClient.GetCustomerInformation(string? agreementReference, int? proposalId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DocumentParameter> IBlueApiClient.GetLetterParameters(ApiParameterSource parameterSouce)
        {
            throw new NotImplementedException();
        }
    }
}
