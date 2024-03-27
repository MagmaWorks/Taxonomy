namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class NorthernMarianaIslands : SingletonCountryBase<NorthernMarianaIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Northern Mariana Islands";
        private const string _countryCode = "MP";

        public NorthernMarianaIslands() { }
    }
}

