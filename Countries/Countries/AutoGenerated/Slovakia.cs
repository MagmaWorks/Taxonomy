namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Slovakia : SingletonCountryBase<Slovakia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Slovakia";
        private const string _countryCode = "SK";

        public Slovakia() { }
    }
}

