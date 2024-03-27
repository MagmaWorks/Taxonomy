namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Honduras : SingletonCountryBase<Honduras>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Honduras";
        private const string _countryCode = "HN";

        public Honduras() { }
    }
}

