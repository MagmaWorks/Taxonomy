namespace MagmaWorks.Taxonomy.Countries
{
    public class Brazil : ISouthAmerica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Brazil";
        private const string _countryCode = "BR";
        private const int _currencyCode = 986;

        public Brazil() { }
    }
}
