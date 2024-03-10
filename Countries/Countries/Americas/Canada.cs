namespace MagmaWorks.Taxonomy.Countries
{
    public class Canada : INorthernAmerica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Canada";
        private const string _countryCode = "CA";
        private const int _currencyCode = 124;

        public Canada() { }
    }
}
