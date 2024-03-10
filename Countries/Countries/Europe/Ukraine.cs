namespace MagmaWorks.Taxonomy.Countries
{
    public class Ukraine : IEasternEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Ukraine";
        private const string _countryCode = "UA";
        private const int _currencyCode = 980;

        public Ukraine() { }
    }
}
