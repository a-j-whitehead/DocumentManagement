using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.Domain.DocumentParameters
{
    public abstract class DocumentParameter //TODO - put this in NoSQL, or blob?
    {
        internal Guid LetterParameterId { get; set; }
        
        internal Guid LetterId { get; set; }
        internal BlueDocument Letter { get; set; }

        internal Guid ParameterSchemaId { get; set; }
        internal ParameterSchema ParameterSchema { get; set; }
        
        internal abstract string JsonValue();

        internal DocumentParameter(ParameterSchema parameterSchema)
        {
            LetterParameterId = Guid.NewGuid();
            ParameterSchema = parameterSchema;
            ParameterSchemaId = parameterSchema.ParameterSchemaId;
        }
    }
}