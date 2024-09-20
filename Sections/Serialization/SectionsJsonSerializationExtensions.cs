using MagmaWorks.Taxonomy.Sections;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Sections.Extensions
{
    public static class ProfileJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : ISection
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : ISection
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
