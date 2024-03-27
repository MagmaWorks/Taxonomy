namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SolomonIslands : SingletonCountryBase<SolomonIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Solomon Islands";
        private const string _countryCode = "SB";

        public SolomonIslands() { }
    }
}

