using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Library.Common.Tools
{
    public static class JsonSerializer
    {
        private static readonly JsonSerializerSettings _settings;

        static JsonSerializer()
        {
            _settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }

        public static T Deserialize<T>(string jsonObj)
        {
            return JsonConvert.DeserializeObject<T>(jsonObj, _settings);
        }
    }
}
