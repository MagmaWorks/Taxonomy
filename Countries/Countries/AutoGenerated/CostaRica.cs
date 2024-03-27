namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CostaRica : SingletonCountryBase<CostaRica>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Costa Rica";
        private const string _countryCode = "CR";

        public CostaRica() { }
    }
}

