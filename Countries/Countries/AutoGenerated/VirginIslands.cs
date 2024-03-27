namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class VirginIslands : SingletonCountryBase<VirginIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Virgin Islands";
        private const string _countryCode = "VI";

        public VirginIslands() { }
    }
}

