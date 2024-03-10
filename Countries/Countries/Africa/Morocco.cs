namespace MagmaWorks.Taxonomy.Countries
{
    public class Morocco : INorthernAfrica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Morocco";
        private const string _countryCode = "MA";
        private const int _currencyCode = 504;

        public Morocco() { }
    }
}
