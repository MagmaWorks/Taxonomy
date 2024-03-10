namespace MagmaWorks.Taxonomy.Countries
{
    public class USA : INorthernAmerica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "USA";
        private const string _countryCode = "US";
        private const int _currencyCode = 840;

        public USA() { }
    }
}
