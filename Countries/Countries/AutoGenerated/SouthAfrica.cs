namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SouthAfrica : SingletonCountryBase<SouthAfrica>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "South Africa";
        private const string _countryCode = "ZA";

        public SouthAfrica() { }
    }
}

