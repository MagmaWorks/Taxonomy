namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Denmark : SingletonCountryBase<Denmark>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Denmark";
        private const string _countryCode = "DK";

        public Denmark() { }
    }
}

