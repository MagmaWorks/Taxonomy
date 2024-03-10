namespace MagmaWorks.Taxonomy.Countries
{
    public class Iran : ISouthernAsia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Iran";
        private const string _countryCode = "IR";
        private const int _currencyCode = 364;

        public Iran() { }
    }
}
