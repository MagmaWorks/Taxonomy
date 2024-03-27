namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Jordan : SingletonCountryBase<Jordan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Jordan";
        private const string _countryCode = "JO";

        public Jordan() { }
    }
}

