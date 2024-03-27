namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class TurksAndCaicosIslands : SingletonCountryBase<TurksAndCaicosIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Turks and Caicos Islands";
        private const string _countryCode = "TC";

        public TurksAndCaicosIslands() { }
    }
}

