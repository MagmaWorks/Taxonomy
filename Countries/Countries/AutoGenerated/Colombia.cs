namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Colombia : SingletonCountryBase<Colombia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Colombia";
        private const string _countryCode = "CO";

        public Colombia() { }
    }
}

