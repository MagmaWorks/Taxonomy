namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Iran : SingletonCountryBase<Iran>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Iran";
        private const string _countryCode = "IR";

        public Iran() { }
    }
}

