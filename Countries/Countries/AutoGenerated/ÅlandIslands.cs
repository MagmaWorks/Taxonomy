namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class ÅlandIslands : SingletonCountryBase<ÅlandIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Åland Islands";
        private const string _countryCode = "AX";

        public ÅlandIslands() { }
    }
}

