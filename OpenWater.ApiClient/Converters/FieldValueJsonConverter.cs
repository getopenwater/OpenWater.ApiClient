using OpenWater.ApiClient.Fields;

namespace OpenWater.ApiClient.Converters
{
    internal class FieldJsonConverter : DerivedClassJsonConverterBase<FieldModelBase>
    {
        internal override string GetTypeConcreteNamespace(string typeName) =>
            $"OpenWater.ApiClient.Fields.{typeName}FieldModel";
    }
}