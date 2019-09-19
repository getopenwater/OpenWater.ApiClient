using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace OpenWater.ApiClient.Converters
{
    internal abstract class DerivedClassJsonConverter<T> : JsonConverter
    {
        private Dictionary<string, Type> _modelTypes;
        private readonly object _syncRoot = new object();

        private IReadOnlyDictionary<string, Type> ModelTypesSingleton
        {
            get
            {
                lock (_syncRoot)
                {
                    if (_modelTypes != null)
                        return _modelTypes;

                    var baseType = typeof(T);
                    var assemblyTypes = Assembly.GetAssembly(baseType).GetTypes();

                    _modelTypes = assemblyTypes
                        .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                        .ToList()
                        .Select(dt => (dt, dt)).ToDictionary(tk => tk.Item1.ToString(), tv => tv.Item2);
                }

                return _modelTypes;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException($"{GetType().Name} can be used only for json deserialization.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            if (!jObject.TryGetValue(GetObjectTypeJsonField(), out var typeName))
                return null;

            var fieldValuesModelType = ModelTypesSingleton[GetTypeConcreteNamespace(typeName.ToString())];

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

        public override bool CanWrite => false;

        internal abstract string GetTypeConcreteNamespace(string typeName);
        internal virtual string GetObjectTypeJsonField() => "typeName";
    }
}