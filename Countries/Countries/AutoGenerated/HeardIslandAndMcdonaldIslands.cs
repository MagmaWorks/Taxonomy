namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class HeardIslandAndMcdonaldIslands : SingletonCountryBase<HeardIslandAndMcdonaldIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Heard Island and McDonald Islands";
        private const string _countryCode = "HM";

        public HeardIslandAndMcdonaldIslands() { }
    }
}

