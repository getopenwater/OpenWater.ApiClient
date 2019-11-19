using System;
using System.Collections.Generic;
using System.Linq;
using NJsonSchema;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class ModelWithNamespaceTypeNameGenerator : DefaultTypeNameGenerator
    {
        private readonly Dictionary<string, ModelNameWithNamespaceInfo> _typeNameHintsModelNameWithNamespaceInfos = new Dictionary<string, ModelNameWithNamespaceInfo>();

        public IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> TypeNameHintsModelNameWithNamespaceInfos => _typeNameHintsModelNameWithNamespaceInfos;

        public override string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            if (schema.IsObject)
            {
                if (IsGenericTypeNameHint(typeNameHint))
                    return HandleGenericTypeNameHint(typeNameHint);

                if (IsSubclassTypeNameHint(typeNameHint))
                    return HandleSubclassTypeNameHint(typeNameHint);

                return HandleRegularTypeNameHint(typeNameHint);
            }

            return base.Generate(schema, typeNameHint, reservedTypeNames);
        }

        private string HandleRegularTypeNameHint(string typeNameHint)
        {
            var sections = typeNameHint.Split(".");
            var typeName = sections[sections.Length - 1];
            var @namespace = sections[sections.Length - 2];

            var typeNameInfo = new ModelNameWithNamespaceInfo(@namespace, typeName);

            _typeNameHintsModelNameWithNamespaceInfos.Add(typeNameHint, typeNameInfo);

            return typeNameInfo.FullName;
        }

        private bool IsGenericTypeNameHint(string typeNameHint)
        {
            return typeNameHint.Contains("`");
        }

        private string HandleGenericTypeNameHint(string genericTypeNameHint)
        {
            if (!genericTypeNameHint.Contains("`1"))
                throw new InvalidOperationException("Generics with more then one generic argument are not supported.");

            // generics are looks like AwardsCms.Web.Admin.Api.Pagination.PagingResponse`1[[AwardsCms.Web.Admin.Api.Models.Invoice.BillingLineItemListItemModel, AwardsCms.Web.Admin.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
            var genericTypeAndGenericArgumentSections = genericTypeNameHint.Split("`1[[");
            var genericArgumentType = genericTypeAndGenericArgumentSections.Last().Split(",").First();
            var genericArgumentTypeSections = genericArgumentType.Split(".");
            var genericArgumentTypeNamespace = genericArgumentTypeSections[genericArgumentTypeSections.Length - 2];

            var genericTypeSections = genericTypeAndGenericArgumentSections.First().Split(".");
            var genericTypeName = genericTypeSections.Last();

            var typeNameInfo = new ModelNameWithNamespaceInfo(genericArgumentTypeNamespace, genericTypeName + genericArgumentTypeSections.Last());

            _typeNameHintsModelNameWithNamespaceInfos.Add(genericTypeNameHint, typeNameInfo);

            return typeNameInfo.FullName;
        }

        private static bool IsSubclassTypeNameHint(string typeNameHint)
        {
            return typeNameHint.Contains("+");
        }

        private string HandleSubclassTypeNameHint(string typeNameHint)
        {
            var sections = typeNameHint.Split(".");
            var typeName = sections[sections.Length - 1].Split("+").Last();
            var @namespace = sections[sections.Length - 2];

            var typeNameInfo = new ModelNameWithNamespaceInfo(@namespace, typeName);

            _typeNameHintsModelNameWithNamespaceInfos.Add(typeNameHint, typeNameInfo);

            return typeNameInfo.FullName;
        }
    }
}