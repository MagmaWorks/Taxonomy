namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class China : SingletonCountryBase<China>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "China";
        private const string _countryCode = "CN";

        public China() { }
    }
}

