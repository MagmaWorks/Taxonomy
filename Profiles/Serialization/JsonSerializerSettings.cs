using Newtonsoft.Json;

namespace MagmaWorks.Taxonomy.Serialization
{
    internal static class TaxonomyJsonSerializer
    {
        internal static JsonSerializerSettings Settings
        {
            get
            {
                var settings = new JsonSerializerSettings
                {
                    Converters = {
                        new OasysUnits.Serialization.JsonNet.OasysUnitsIQuantityJsonConverter(),
                    },
                    TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
                };
                return settings;
            }
        }
    }
}
