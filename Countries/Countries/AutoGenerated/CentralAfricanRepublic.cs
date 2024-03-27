namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CentralAfricanRepublic : SingletonCountryBase<CentralAfricanRepublic>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Central African Republic";
        private const string _countryCode = "CF";

        public CentralAfricanRepublic() { }
    }
}

