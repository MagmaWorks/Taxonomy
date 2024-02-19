using MagmaWorks.Taxonomy.Profiles;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Profiles.Extensions
{
    public static class ProfileJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : IProfile
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : IProfile
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
