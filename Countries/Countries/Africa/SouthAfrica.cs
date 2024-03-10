namespace MagmaWorks.Taxonomy.Countries
{
    public class SouthAfrica : ISouthernAfrica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "South Africa";
        private const string _countryCode = "ZA";
        private const int _currencyCode = 710;

        public SouthAfrica() { }
    }
}
