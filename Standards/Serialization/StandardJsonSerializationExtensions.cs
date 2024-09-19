using MagmaWorks.Taxonomy.Standards;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Standards.Extensions
{
    public static class StandardJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : IStandard
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : IStandard
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
