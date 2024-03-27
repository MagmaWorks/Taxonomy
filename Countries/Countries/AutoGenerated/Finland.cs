namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Finland : SingletonCountryBase<Finland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Finland";
        private const string _countryCode = "FI";

        public Finland() { }
    }
}

