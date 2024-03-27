namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Ecuador : SingletonCountryBase<Ecuador>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Ecuador";
        private const string _countryCode = "EC";

        public Ecuador() { }
    }
}

