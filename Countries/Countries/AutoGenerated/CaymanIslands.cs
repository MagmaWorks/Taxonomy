namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CaymanIslands : SingletonCountryBase<CaymanIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cayman Islands";
        private const string _countryCode = "KY";

        public CaymanIslands() { }
    }
}

