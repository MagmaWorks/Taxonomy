namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Algeria : SingletonCountryBase<Algeria>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Algeria";
        private const string _countryCode = "DZ";

        public Algeria() { }
    }
}

