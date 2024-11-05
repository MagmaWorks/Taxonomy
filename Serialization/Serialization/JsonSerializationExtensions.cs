using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization
{
    public static class JsonSerializationExtensions
    {
        public static string ToJson<T>(this T taxonomyObject, JsonSerializerSettings? settings = null) where T : ITaxonomySerializable
        {
            if (settings == null)
            {
                return JsonConvert.SerializeObject(taxonomyObject, Formatting.Indented, TaxonomyJsonSerializer.Settings);
            }

            return JsonConvert.SerializeObject(taxonomyObject, Formatting.Indented, settings);
        }

        public static T? FromJson<T>(this string json, JsonSerializerSettings? settings = null) where T : ITaxonomySerializable
        {
            if (settings == null)
            {
                return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
            }

            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}
