namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Cambodia : SingletonCountryBase<Cambodia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cambodia";
        private const string _countryCode = "KH";

        public Cambodia() { }
    }
}

