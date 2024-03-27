namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Sweden : SingletonCountryBase<Sweden>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sweden";
        private const string _countryCode = "SE";

        public Sweden() { }
    }
}

