using MagmaWorks.Taxonomy.Materials;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Materials.Extensions
{
    public static class MaterialJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : IMaterial
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : IMaterial
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
