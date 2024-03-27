namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class HongKong : SingletonCountryBase<HongKong>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Hong Kong";
        private const string _countryCode = "HK";

        public HongKong() { }
    }
}

