namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Canada : SingletonCountryBase<Canada>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Canada";
        private const string _countryCode = "CA";

        public Canada() { }
    }
}

