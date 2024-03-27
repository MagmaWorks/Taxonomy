namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class DominicanRepublic : SingletonCountryBase<DominicanRepublic>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Dominican Republic";
        private const string _countryCode = "DO";

        public DominicanRepublic() { }
    }
}

