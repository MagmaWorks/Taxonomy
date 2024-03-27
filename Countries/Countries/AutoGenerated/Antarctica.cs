namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Antarctica : SingletonCountryBase<Antarctica>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Antarctica";
        private const string _countryCode = "AQ";

        public Antarctica() { }
    }
}

