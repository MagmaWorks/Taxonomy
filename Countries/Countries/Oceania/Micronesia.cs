namespace MagmaWorks.Taxonomy.Countries
{
    public class Micronesia : IMicronesia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Micronesia";
        private const string _countryCode = "FM";
        private const int _currencyCode = 840;

        public Micronesia() { }
    }
}
