namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Pakistan : SingletonCountryBase<Pakistan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Pakistan";
        private const string _countryCode = "PK";

        public Pakistan() { }
    }
}

