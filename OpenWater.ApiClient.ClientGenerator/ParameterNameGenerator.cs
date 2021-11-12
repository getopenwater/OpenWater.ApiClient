using System.Collections.Generic;
using NJsonSchema;
using NSwag;
using NSwag.CodeGeneration;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class ParameterNameGenerator : IParameterNameGenerator
    {
        public string Generate(OpenApiParameter parameter, IEnumerable<OpenApiParameter> allParameters)
        {
            const string customHeaderPrefix = "x_";
            const string bodyParameterNameExtensionKey = "x-codegen-request-body-name";

            if (string.IsNullOrEmpty(parameter.Name))
                return "unnamed";

            if (parameter.Kind == OpenApiParameterKind.Body && parameter.Parent is OpenApiOperation operation && operation.ExtensionData != null && operation.ExtensionData.TryGetValue(bodyParameterNameExtensionKey, out var bodyParameterName))
                return (string)bodyParameterName;

            var lowerCamelCase = ConversionUtilities.ConvertToLowerCamelCase(parameter.Name.Replace("-", "_")
                .Replace(".", "_").Replace("$", string.Empty)
                .Replace("[", string.Empty)
                .Replace("]", string.Empty), true);

            if (lowerCamelCase.Length <= customHeaderPrefix.Length || !lowerCamelCase.StartsWith(customHeaderPrefix))
                return lowerCamelCase;

            lowerCamelCase = lowerCamelCase.Remove(0, customHeaderPrefix.Length);
            lowerCamelCase = char.ToLowerInvariant(lowerCamelCase[0]) + lowerCamelCase.Substring(1);

            return lowerCamelCase;
        }
    }
}
