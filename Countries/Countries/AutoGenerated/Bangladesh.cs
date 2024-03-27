namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bangladesh : SingletonCountryBase<Bangladesh>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bangladesh";
        private const string _countryCode = "BD";

        public Bangladesh() { }
    }
}

