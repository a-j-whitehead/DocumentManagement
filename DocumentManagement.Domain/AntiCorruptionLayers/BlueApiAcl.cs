using DocumentManagement.Domain.AntiCorruptionLayers.Dtos;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.Domain.AntiCorruptionLayers
{
    public class BlueApiAcl
    {
        CustomerInformationDto GetCustomerInformation(string? agreementReference, int? proposalId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DocumentParameter> GetLetterParameters(ApiParameterSource parameterSouce)
        {
            throw new NotImplementedException();
        }
    }
}
