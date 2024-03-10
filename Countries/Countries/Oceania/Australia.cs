namespace MagmaWorks.Taxonomy.Countries
{
    public class Australia : IAustraliaAndNewZealand
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Australia";
        private const string _countryCode = "AU";
        private const int _currencyCode = 036;

        public Australia() { }
    }
}
