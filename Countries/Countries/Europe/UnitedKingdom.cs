namespace MagmaWorks.Taxonomy.Countries
{
    public class UnitedKingdom : INorthernEurope
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "United Kingdom";
        private const string _countryCode = "GB";
        private const int _currencyCode = 826;

        public UnitedKingdom() { }
    }
}
