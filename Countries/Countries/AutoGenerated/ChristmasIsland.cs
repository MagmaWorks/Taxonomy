namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class ChristmasIsland : SingletonCountryBase<ChristmasIsland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Christmas Island";
        private const string _countryCode = "CX";

        public ChristmasIsland() { }
    }
}

