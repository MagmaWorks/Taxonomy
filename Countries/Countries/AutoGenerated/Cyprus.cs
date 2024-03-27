namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Cyprus : SingletonCountryBase<Cyprus>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cyprus";
        private const string _countryCode = "CY";

        public Cyprus() { }
    }
}

