using Aspose.Words;
using DocumentManagement.Domain.LetterParameters;

namespace DocumentManagement.Domain.DocumentParameters
{
    // TODO - Look at DDD services
    internal abstract class AsposeParameterReader
    {
        internal static Stream ApplyParametersToDocument(Stream templateStream, List<DocumentParameter> letterParameters)
        {
            var document = new Document(templateStream);

            foreach (var letterParameter in letterParameters)
            {
                if (letterParameter is StringDocumentParameter stringParameter)
                {
                    document = ApplyStringParameter(document, stringParameter);
                }
                else
                {
                    // To add more parameter types:
                    //  * create new classes inheriting from DocumentParameter
                    //  * implement new ApplyParameter method
                    throw new NotImplementedException($"Parameter type {letterParameter.GetType().Name} not implemented");
                }
            }

            var outputStream = new MemoryStream();
            document.Save(outputStream, SaveFormat.Pdf);
            outputStream.Position = 0;

            return outputStream;
        }

        internal static Document ApplyStringParameter(Document template, StringDocumentParameter parameter)
        {
            string placeholder = $"*{{{parameter.ParameterSchema.Name}}}";
            string value = parameter.Value;
            template.Range.Replace(placeholder, value);

            return template;
        }
    }
}
