namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Paraguay : SingletonCountryBase<Paraguay>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Paraguay";
        private const string _countryCode = "PY";

        public Paraguay() { }
    }
}

