namespace MagmaWorks.Taxonomy.Countries
{
    public class Mexico : ICentralAmerica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Mexico";
        private const string _countryCode = "MX";
        private const int _currencyCode = 484;

        public Mexico() { }
    }
}
