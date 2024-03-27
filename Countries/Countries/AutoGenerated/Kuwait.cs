namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Kuwait : SingletonCountryBase<Kuwait>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Kuwait";
        private const string _countryCode = "KW";

        public Kuwait() { }
    }
}

