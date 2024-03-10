namespace MagmaWorks.Taxonomy.Countries
{
    public class Finland : INorthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Finland";
        private const string _countryCode = "FI";
        private const int _currencyCode = 978;

        public Finland() { }
    }
}
