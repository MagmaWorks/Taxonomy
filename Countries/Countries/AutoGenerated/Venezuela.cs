namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Venezuela : SingletonCountryBase<Venezuela>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Venezuela";
        private const string _countryCode = "VE";

        public Venezuela() { }
    }
}

