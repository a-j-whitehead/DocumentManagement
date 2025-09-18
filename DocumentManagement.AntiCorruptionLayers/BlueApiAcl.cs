using DocumentManagement.Domain.Clients.Dtos;
using DocumentManagement.Domain.DocumentParameters;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.AntiCorruptionLayers
{
    public class BlueApiAcl : IBlueApiAcl
    {
        CustomerInformationDto IBlueApiAcl.GetCustomerInformation(string? agreementReference, int? proposalId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DocumentParameter> IBlueApiAcl.GetLetterParameters(ApiParameterSource parameterSouce)
        {
            throw new NotImplementedException();
        }
    }
}
