namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Cuba : SingletonCountryBase<Cuba>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cuba";
        private const string _countryCode = "CU";

        public Cuba() { }
    }
}

