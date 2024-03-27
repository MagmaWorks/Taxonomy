namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Brazil : SingletonCountryBase<Brazil>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Brazil";
        private const string _countryCode = "BR";

        public Brazil() { }
    }
}

