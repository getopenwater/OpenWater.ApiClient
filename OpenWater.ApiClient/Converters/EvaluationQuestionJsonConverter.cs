using OpenWater.ApiClient.EvaluationQuestions;

namespace OpenWater.ApiClient.Converters
{
    internal class EvaluationQuestionJsonConverter : DerivedClassJsonConverterBase<EvaluationQuestionModelBase>
    {
        internal override string GetTypeConcreteNamespace(string typeName) =>
            $"OpenWater.ApiClient.EvaluationQuestions.{typeName}Model";
    }
}