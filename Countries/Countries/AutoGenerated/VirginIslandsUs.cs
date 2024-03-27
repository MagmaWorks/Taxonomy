namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class VirginIslandsUs : SingletonCountryBase<VirginIslandsUs>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Virgin Islands U.S.";
        private const string _countryCode = "VI";

        public VirginIslandsUs() { }
    }
}

