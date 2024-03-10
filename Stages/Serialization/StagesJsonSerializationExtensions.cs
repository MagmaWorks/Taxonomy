using MagmaWorks.Taxonomy.Stages;
using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization.Stages.Extensions
{
    public static class ProfileJsonSerializationExtensions
    {
        public static string ToJson<T>(this T profile) where T : IStage
        {
            return JsonConvert.SerializeObject(profile, Formatting.Indented, TaxonomyJsonSerializer.Settings);
        }

        public static T FromJson<T>(this string json) where T : IStage
        {
            return JsonConvert.DeserializeObject<T>(json, TaxonomyJsonSerializer.Settings);
        }
    }
}
