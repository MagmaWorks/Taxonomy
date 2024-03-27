namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Palestine : SingletonCountryBase<Palestine>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Palestine";
        private const string _countryCode = "PS";

        public Palestine() { }
    }
}

