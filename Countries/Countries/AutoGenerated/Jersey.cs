namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Jersey : SingletonCountryBase<Jersey>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Jersey";
        private const string _countryCode = "JE";

        public Jersey() { }
    }
}

