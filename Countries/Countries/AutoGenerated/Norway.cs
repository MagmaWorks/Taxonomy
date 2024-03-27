namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Norway : SingletonCountryBase<Norway>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Norway";
        private const string _countryCode = "NO";

        public Norway() { }
    }
}

