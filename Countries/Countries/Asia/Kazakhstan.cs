namespace MagmaWorks.Taxonomy.Countries
{
    public class Kazakhstan : ICentralAsia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Kazakhstan";
        private const string _countryCode = "KZ";
        private const int _currencyCode = 398;

        public Kazakhstan() { }
    }
}
