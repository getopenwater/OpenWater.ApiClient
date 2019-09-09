using OpenWater.ApiClient.Fields;

namespace OpenWater.ApiClient.Converters
{
    internal class FieldJsonConverter : DerivedClassJsonConverter<FieldModelBase>
    {
        internal override string GetTypeConcreteNamespace(string typeName) =>
            $"OpenWater.ApiClient.Fields.{typeName}FieldModel";
    }
}