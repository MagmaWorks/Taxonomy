namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Netherlands : SingletonCountryBase<Netherlands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Netherlands";
        private const string _countryCode = "NL";

        public Netherlands() { }
    }
}

