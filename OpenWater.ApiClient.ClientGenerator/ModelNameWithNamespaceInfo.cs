using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class ModelNameWithNamespaceInfo
    {
        public string ModelNamespace { get; }
        public string ModelName { get; }
        public string FullName => $"{ModelNamespace}.{ModelName}";

        public ModelNameWithNamespaceInfo(string modelNamespace, string modelName)
        {
            ModelNamespace = modelNamespace;
            ModelName = modelName;
        }

        public override string ToString() => FullName;

        public string GetTypeName(string currentModelNamespace)
        {
            return currentModelNamespace == ModelNamespace ? ModelName : FullName;
        }
    }
}