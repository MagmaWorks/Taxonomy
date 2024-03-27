namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Belgium : SingletonCountryBase<Belgium>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Belgium";
        private const string _countryCode = "BE";

        public Belgium() { }
    }
}

