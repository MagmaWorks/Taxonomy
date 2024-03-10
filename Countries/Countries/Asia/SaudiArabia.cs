namespace MagmaWorks.Taxonomy.Countries
{
    public class SaudiArabia : IWesternAsia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Saudi Arabia";
        private const string _countryCode = "SA";
        private const int _currencyCode = 682;

        public SaudiArabia() { }
    }
}
