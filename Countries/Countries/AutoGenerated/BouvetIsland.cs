namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class BouvetIsland : SingletonCountryBase<BouvetIsland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bouvet Island";
        private const string _countryCode = "BV";

        public BouvetIsland() { }
    }
}

