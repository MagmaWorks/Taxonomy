﻿using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Countries
{
    public interface ICountry : ITaxonomySerializable
    {
        /// <summary>
        /// Country name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Two-letter country code as defined by ISO 3166-1 alpha-2
        /// </summary>
        string CountryCode { get; }
    }
}
