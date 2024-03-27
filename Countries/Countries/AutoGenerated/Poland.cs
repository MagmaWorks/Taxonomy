namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Poland : SingletonCountryBase<Poland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Poland";
        private const string _countryCode = "PL";

        public Poland() { }
    }
}

