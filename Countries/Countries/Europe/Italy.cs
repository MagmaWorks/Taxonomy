namespace MagmaWorks.Taxonomy.Countries
{
    public class Italy : ISouthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Italy";
        private const string _countryCode = "IT";
        private const int _currencyCode = 978;

        public Italy() { }
    }
}
