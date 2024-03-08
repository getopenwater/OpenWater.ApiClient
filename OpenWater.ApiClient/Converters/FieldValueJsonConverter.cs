using OpenWater.ApiClient.FieldValues;

namespace OpenWater.ApiClient.Converters
{
    internal class FieldValueJsonConverter : DerivedClassJsonConverterBase<FieldValueModelBase>
    {
        internal override string GetTypeConcreteNamespace(string typeName) =>
            $"OpenWater.ApiClient.FieldValues.{typeName}Model";
    }
}