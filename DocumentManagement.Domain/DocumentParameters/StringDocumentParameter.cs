using DocumentManagement.Domain.DocumentParameters;

namespace DocumentManagement.Domain.LetterParameters
{
    internal class StringDocumentParameter : DocumentParameter
    {
        internal string Value { get; }
        internal override string JsonValue()
        {
            return Value;
        }

        public StringDocumentParameter(ParameterSchema parameterSchema, string value)
            : base(parameterSchema)
        {
            Value = value;
        }
    }
}