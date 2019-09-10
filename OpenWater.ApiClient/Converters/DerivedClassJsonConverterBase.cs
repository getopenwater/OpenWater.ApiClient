using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace OpenWater.ApiClient.Converters
{
    internal abstract class DerivedClassJsonConverterBase<T> : JsonConverter
    {
        private readonly object _syncRoot = new object();

        private Dictionary<string, Type> _modelTypes;

        private IReadOnlyDictionary<string, Type> ModelTypes => GetModelTypes();

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException($"{GetType().Name} can be used only for json deserialization.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            const string objectTypeJsonField = "typeName";
            var jObject = JObject.Load(reader);

            if (!jObject.TryGetValue(objectTypeJsonField, out var typeName))
                return null;

            var fieldValuesModelType = ModelTypes[GetTypeConcreteNamespace(typeName.ToString())];

            var concreteValueModel = Create(fieldValuesModelType);
            JsonConvert.PopulateObject(jObject.ToString(), concreteValueModel);

            return concreteValueModel;
        }

        public T Create(Type objectType)
        {
            var objectConstructor = objectType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).First();

            return (T)objectConstructor.Invoke(null);
        }

        public override bool CanConvert(Type objectType) => objectType.IsAbstract;

        internal abstract string GetTypeConcreteNamespace(string typeName);

        private IReadOnlyDictionary<string, Type> GetModelTypes()
        {
            lock (_syncRoot)
            {
                if (_modelTypes != null)
                    return _modelTypes;

                var baseType = typeof(T);
                var assemblyTypes = Assembly.GetAssembly(baseType).GetTypes();

                _modelTypes = assemblyTypes
                    .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                    .ToDictionary(dt => dt.ToString());
            }

            return _modelTypes;
        }
    }
}