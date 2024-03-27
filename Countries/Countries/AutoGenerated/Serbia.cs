namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Serbia : SingletonCountryBase<Serbia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Serbia";
        private const string _countryCode = "RS";

        public Serbia() { }
    }
}

