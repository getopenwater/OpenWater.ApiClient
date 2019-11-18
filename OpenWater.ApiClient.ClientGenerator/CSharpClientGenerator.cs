using System;
using System.Collections.Generic;
using System.Linq;
using NJsonSchema.CodeGeneration;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class CustomCSharpClientGenerator : CSharpClientGenerator
    {
        private readonly OpenApiDocument _document;

        public bool IsDefinitionGeneration { get; set; }

        public CustomCSharpClientGenerator(OpenApiDocument document, CSharpClientGeneratorSettings settings) : base(document, settings)
        {
            _document = document;
        }

        public CustomCSharpClientGenerator(OpenApiDocument document, CSharpClientGeneratorSettings settings, CSharpTypeResolver resolver) : base(document, settings, resolver)
        {
            _document = document;
        }

        protected override IEnumerable<CodeArtifact> GenerateDtoTypes()
        {
            if (IsDefinitionGeneration)
                return base.GenerateDtoTypes();

            return GenerateDtoTypesExcludeDefinedEnums();
        }

        private IEnumerable<CodeArtifact> GenerateDtoTypesExcludeDefinedEnums()
        {
            var definedEnums = _document.Definitions.Where(d => d.Value.IsEnumeration).Select(d => d.Key.Split('.').Last()).ToArray();

            foreach (var dtoType in base.GenerateDtoTypes())
            {
                if (!definedEnums.Any(de => dtoType.TypeName.StartsWith(de, StringComparison.InvariantCulture)))
                    yield return dtoType;
            }
        }
    }
}
