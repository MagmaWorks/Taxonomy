namespace MagmaWorks.Taxonomy.Countries
{
    public class Tonga : IPolynesia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Tonga";
        private const string _countryCode = "TO";
        private const int _currencyCode = 776;

        public Tonga() { }
    }
}
