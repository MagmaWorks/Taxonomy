namespace MagmaWorks.Taxonomy.Countries
{
    public class Norway : INorthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Norway";
        private const string _countryCode = "NO";
        private const int _currencyCode = 578;

        public Norway() { }
    }
}
