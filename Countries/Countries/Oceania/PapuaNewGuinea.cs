namespace MagmaWorks.Taxonomy.Countries
{
    public class PapuaNewGuinea : IMelanesia
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Papua New Guinea";
        private const string _countryCode = "PG";
        private const int _currencyCode = 598;

        public PapuaNewGuinea() { }
    }
}
