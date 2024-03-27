namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class MarshallIslands : SingletonCountryBase<MarshallIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Marshall Islands";
        private const string _countryCode = "MH";

        public MarshallIslands() { }
    }
}

