namespace MagmaWorks.Taxonomy.Countries
{
    public class Singapore : ISouthEasternAsia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Singapore";
        private const string _countryCode = "SG";
        private const int _currencyCode = 702;

        public Singapore() { }
    }
}
