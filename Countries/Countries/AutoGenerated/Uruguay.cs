namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Uruguay : SingletonCountryBase<Uruguay>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Uruguay";
        private const string _countryCode = "UY";

        public Uruguay() { }
    }
}

