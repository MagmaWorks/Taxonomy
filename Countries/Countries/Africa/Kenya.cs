namespace MagmaWorks.Taxonomy.Countries
{
    public class Kenya : IEasternAfrica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Kenya";
        private const string _countryCode = "KE";
        private const int _currencyCode = 404;

        public Kenya() { }
    }
}
