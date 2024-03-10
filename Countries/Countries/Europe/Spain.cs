namespace MagmaWorks.Taxonomy.Countries
{
    public class Spain : ISouthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Spain";
        private const string _countryCode = "ES";
        private const int _currencyCode = 978;

        public Spain() { }
    }
}
