using Newtonsoft.Json;
using OpenWater.ApiClient.Converters;

// ReSharper disable once CheckNamespace
namespace OpenWater.ApiClient.EvaluationQuestions
{
    [JsonConverter(typeof(EvaluationQuestionJsonConverter))]
    public abstract partial class EvaluationQuestionModelBase
    {
    }
}