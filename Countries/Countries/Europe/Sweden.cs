namespace MagmaWorks.Taxonomy.Countries
{
    public class Sweden : INorthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Sweden";
        private const string _countryCode = "SE";
        private const int _currencyCode = 752;

        public Sweden() { }
    }
}
