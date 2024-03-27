namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Ireland : SingletonCountryBase<Ireland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Ireland";
        private const string _countryCode = "IE";

        public Ireland() { }
    }
}

