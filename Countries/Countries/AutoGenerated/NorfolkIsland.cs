namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class NorfolkIsland : SingletonCountryBase<NorfolkIsland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Norfolk Island";
        private const string _countryCode = "NF";

        public NorfolkIsland() { }
    }
}

