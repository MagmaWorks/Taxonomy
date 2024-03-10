namespace MagmaWorks.Taxonomy.Countries
{
    public class China : IEasternAsia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "China";
        private const string _countryCode = "CN";
        private const int _currencyCode = 156;

        public China() { }
    }
}
