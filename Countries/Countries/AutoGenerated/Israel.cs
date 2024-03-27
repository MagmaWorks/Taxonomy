namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Israel : SingletonCountryBase<Israel>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Israel";
        private const string _countryCode = "IL";

        public Israel() { }
    }
}

