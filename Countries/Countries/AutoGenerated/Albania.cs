namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Albania : SingletonCountryBase<Albania>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Albania";
        private const string _countryCode = "AL";

        public Albania() { }
    }
}

