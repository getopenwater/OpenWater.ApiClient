using Newtonsoft.Json;
using OpenWater.ApiClient.Converters;

// ReSharper disable once CheckNamespace
namespace OpenWater.ApiClient.FieldValues
{
    [JsonConverter(typeof(FieldValueJsonConverter))]
    public abstract partial class FieldValueModelBase
    {
    }
}