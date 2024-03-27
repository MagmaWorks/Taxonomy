namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Ukraine : SingletonCountryBase<Ukraine>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Ukraine";
        private const string _countryCode = "UA";

        public Ukraine() { }
    }
}

