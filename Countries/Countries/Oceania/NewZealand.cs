namespace MagmaWorks.Taxonomy.Countries
{
    public class NewZealand : IAustraliaAndNewZealand
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "New Zealand";
        private const string _countryCode = "NZ";
        private const int _currencyCode = 554;

        public NewZealand() { }
    }
}
