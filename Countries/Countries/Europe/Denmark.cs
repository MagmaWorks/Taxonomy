namespace MagmaWorks.Taxonomy.Countries
{
    public class Denmark : INorthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Denmark";
        private const string _countryCode = "DK";
        private const int _currencyCode = 208;

        public Denmark() { }
    }
}
