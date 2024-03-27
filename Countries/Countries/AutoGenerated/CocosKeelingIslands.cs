namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CocosKeelingIslands : SingletonCountryBase<CocosKeelingIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cocos (Keeling) Islands";
        private const string _countryCode = "CC";

        public CocosKeelingIslands() { }
    }
}

