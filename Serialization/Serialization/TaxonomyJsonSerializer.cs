﻿using Newtonsoft.Json;

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
                        new Newtonsoft.Json.Converters.StringEnumConverter(),
                        new UnitsNet.Serialization.JsonNet.UnitsNetIQuantityJsonConverter(),
                    },
                    TypeNameHandling = TypeNameHandling.Objects,
                    TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
                };
                return settings;
            }
        }
    }
}
