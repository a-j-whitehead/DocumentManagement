namespace DocumentManagement.Domain.Infrastructure
{
    public interface IBlueApiClient
    {
        public IEnumerable<LetterParameter> GetLetterParameters(ParameterSource parameterSouce);
    }
}
