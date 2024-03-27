namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CookIslands : SingletonCountryBase<CookIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cook Islands";
        private const string _countryCode = "CK";

        public CookIslands() { }
    }
}

