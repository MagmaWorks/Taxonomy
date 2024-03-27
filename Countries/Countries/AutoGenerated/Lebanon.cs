namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Lebanon : SingletonCountryBase<Lebanon>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Lebanon";
        private const string _countryCode = "LB";

        public Lebanon() { }
    }
}

