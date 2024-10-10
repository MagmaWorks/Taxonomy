using MagmaWorks.Taxonomy.Loads;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Loads
{
    public static class LoadJsonSerializationExtensions
    {
        public static string ToJson<T>(this T load) where T : ILoad
        {
            return JsonConvert.SerializeObject(load, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : ILoad
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
