namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guinea : SingletonCountryBase<Guinea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guinea";
        private const string _countryCode = "GN";

        public Guinea() { }
    }
}

