using System.Linq;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace OpenWater.ApiClient.ClientGenerator
{
    class CustomCSharpClientGenerator : CSharpClientGenerator
    {
        public new static CSharpTypeResolver CreateResolverWithExceptionSchema(CSharpGeneratorSettings settings, OpenApiDocument document)
        {
            var exceptionSchema = document.Definitions.ContainsKey("Exception") ? document.Definitions["Exception"] : null;
            var csharpTypeResolver = new CustomCSharpTypeResolver(settings, exceptionSchema);

            csharpTypeResolver.RegisterSchemaDefinitions(document.Definitions.Where(p => p.Value != exceptionSchema).ToDictionary(p => p.Key, p => p.Value));

            return csharpTypeResolver;
        }

        public CustomCSharpClientGenerator(OpenApiDocument document, CSharpClientGeneratorSettings settings) : this(document, settings, CreateResolverWithExceptionSchema(settings.CSharpGeneratorSettings, document))
        {
        }

        public CustomCSharpClientGenerator(OpenApiDocument document, CSharpClientGeneratorSettings settings, CSharpTypeResolver resolver) : base(document, settings, resolver)
        {
        }
    }
}
