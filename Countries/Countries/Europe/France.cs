namespace MagmaWorks.Taxonomy.Countries
{
    public class France : IWesternEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "France";
        private const string _countryCode = "FR";
        private const int _currencyCode = 978;

        public France() { }
    }
}
