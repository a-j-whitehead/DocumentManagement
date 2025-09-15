namespace DocumentManagement.Domain
{
    internal class LetterParameter
    {
        internal Guid LetterParameterId { get; set; }
        
        internal Guid LetterId { get; set; }
        internal Letter Letter { get; set; }

        internal Guid ParameterSchemaId { get; set; }
        internal ParameterSchema ParameterSchema { get; set; }

        internal string Value { get; set; }
    }
}