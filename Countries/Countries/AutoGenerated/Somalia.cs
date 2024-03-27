namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Somalia : SingletonCountryBase<Somalia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Somalia";
        private const string _countryCode = "SO";

        public Somalia() { }
    }
}

