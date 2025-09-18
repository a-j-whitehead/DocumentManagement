using DocumentManagement.Domain.Clients.Dtos;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.AntiCorruptionLayers
{
    public interface IBlueApiAcl
    {
        CustomerInformationDto GetCustomerInformation(string? agreementReference, int? proposalId);
        IEnumerable<DocumentParameter> GetLetterParameters(ApiParameterSource parameterSouce);
    }
}