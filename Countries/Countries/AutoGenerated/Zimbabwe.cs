namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Zimbabwe : SingletonCountryBase<Zimbabwe>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Zimbabwe";
        private const string _countryCode = "ZW";

        public Zimbabwe() { }
    }
}

