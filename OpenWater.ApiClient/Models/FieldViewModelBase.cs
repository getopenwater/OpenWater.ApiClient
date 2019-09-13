using Newtonsoft.Json;
using OpenWater.ApiClient.Converters;

// ReSharper disable once CheckNamespace
namespace OpenWater.ApiClient.Fields
{
    [JsonConverter(typeof(FieldJsonConverter))]
    public abstract partial class FieldModelBase
    {
    }
}