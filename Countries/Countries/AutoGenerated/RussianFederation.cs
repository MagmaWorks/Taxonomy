namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class RussianFederation : SingletonCountryBase<RussianFederation>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Russian Federation";
        private const string _countryCode = "RU";

        public RussianFederation() { }
    }
}

