using System;
using System.Collections.Generic;
using System.Text;
using NJsonSchema;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class NamespaceRelatedModelTypeNameGenerator : DefaultTypeNameGenerator
    {
        private readonly Dictionary<string, ModelNameWithNamespaceInfo> _typeNameHintsModelNameWithNamespaceInfos;
        private readonly string _currentNamespace;


        public NamespaceRelatedModelTypeNameGenerator(IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelNameWithNamespaceInfos, string currentNamespace)
        {
            _currentNamespace = currentNamespace;
            _typeNameHintsModelNameWithNamespaceInfos = new Dictionary<string, ModelNameWithNamespaceInfo>(typeNameHintsModelNameWithNamespaceInfos);
        }

        public override string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            if (schema.IsObject)
            {
                if (_typeNameHintsModelNameWithNamespaceInfos.TryGetValue(typeNameHint, out var typeNameInfo))
                    return typeNameInfo.GetTypeName(_currentNamespace);

                throw new InvalidOperationException($"Provided {_typeNameHintsModelNameWithNamespaceInfos} dictionary doesn't contain model name info for '{typeNameHint}'.");
            }

            return base.Generate(schema, typeNameHint, reservedTypeNames);
        }
    }
}