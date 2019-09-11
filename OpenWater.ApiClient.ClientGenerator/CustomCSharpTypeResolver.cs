using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class CustomCSharpTypeResolver : CSharpTypeResolver
    {
        public CustomCSharpTypeResolver(CSharpGeneratorSettings settings, JsonSchema exceptionSchema) : base(settings, exceptionSchema)
        {
        }

        public override string Resolve(JsonSchema schema, bool isNullable, string typeNameHint)
        {
            return base.Resolve(schema, schema.IsNullableRaw ?? false, typeNameHint);
        }
    }
}
