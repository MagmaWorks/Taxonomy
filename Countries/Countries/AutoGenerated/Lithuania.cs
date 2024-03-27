namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Lithuania : SingletonCountryBase<Lithuania>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Lithuania";
        private const string _countryCode = "LT";

        public Lithuania() { }
    }
}

