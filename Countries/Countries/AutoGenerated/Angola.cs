namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Angola : SingletonCountryBase<Angola>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Angola";
        private const string _countryCode = "AO";

        public Angola() { }
    }
}

