namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tanzania : SingletonCountryBase<Tanzania>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tanzania";
        private const string _countryCode = "TZ";

        public Tanzania() { }
    }
}

