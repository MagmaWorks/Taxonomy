namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Afghanistan : SingletonCountryBase<Afghanistan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Afghanistan";
        private const string _countryCode = "AF";

        public Afghanistan() { }
    }
}

