namespace MagmaWorks.Taxonomy.Countries
{
    public class Ghana : IWesternAfrica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Ghana";
        private const string _countryCode = "GH";
        private const int _currencyCode = 939;

        public Ghana() { }
    }
}
