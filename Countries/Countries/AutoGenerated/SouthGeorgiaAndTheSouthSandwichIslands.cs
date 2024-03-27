namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SouthGeorgiaAndTheSouthSandwichIslands : SingletonCountryBase<SouthGeorgiaAndTheSouthSandwichIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "South Georgia and the South Sandwich Islands";
        private const string _countryCode = "GS";

        public SouthGeorgiaAndTheSouthSandwichIslands() { }
    }
}

