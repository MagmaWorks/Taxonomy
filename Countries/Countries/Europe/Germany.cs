namespace MagmaWorks.Taxonomy.Countries
{
    public class Germany : IWesternEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Germany";
        private const string _countryCode = "DE";
        private const int _currencyCode = 978;

        public Germany() { }
    }
}
