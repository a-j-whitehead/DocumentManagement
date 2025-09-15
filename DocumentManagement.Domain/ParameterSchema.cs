namespace DocumentManagement.Domain
{
    internal class ParameterSchema
    {
        internal Guid ParameterSchemaId { get; set; }
        internal string Name { get; set; }
        internal Guid ParameterSourceId { get; set; }
        internal ParameterSource ParameterSource { get; set; }
        internal Guid ParameterTypeId { get; set; }
        internal ParameterType ParameterType { get; set; }

        internal ParameterSchema(string name, Guid parameterSourceId, Guid parameterTypeId)
        {
            ParameterSchemaId = Guid.NewGuid();
            Name = name;
            ParameterSourceId = parameterSourceId;
            ParameterTypeId = parameterTypeId;
        }
    }
}