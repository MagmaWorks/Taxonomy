namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Germany : SingletonCountryBase<Germany>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Germany";
        private const string _countryCode = "DE";

        public Germany() { }
    }
}

