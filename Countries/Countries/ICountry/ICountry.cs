namespace MagmaWorks.Taxonomy.Countries
{
    public interface ICountry
    {
        /// <summary>
        /// Country name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Two-letter country code as defined by ISO 3166-1 alpha-2
        /// </summary>
        string CountryCode { get; }

        /// <summary>
        /// Currency code as defined by ISO 4217
        /// </summary>
        int CurrencyCode { get; }
    }
}
