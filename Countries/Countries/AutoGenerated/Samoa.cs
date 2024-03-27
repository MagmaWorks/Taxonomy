namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Samoa : SingletonCountryBase<Samoa>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Samoa";
        private const string _countryCode = "WS";

        public Samoa() { }
    }
}

