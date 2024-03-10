using MagmaWorks.Taxonomy.Countries;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Countries.Extensions
{
    public static class ProfileJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : ICountry
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : ICountry
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
