namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Chad : SingletonCountryBase<Chad>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Chad";
        private const string _countryCode = "TD";

        public Chad() { }
    }
}

