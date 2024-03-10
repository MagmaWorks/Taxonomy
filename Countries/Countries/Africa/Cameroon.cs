namespace MagmaWorks.Taxonomy.Countries
{
    public class Cameroon : IMiddleAfrica
    {
        public string Name => _name;
        public string CountryCode => _countryCode;
        public int CurrencyCode => _currencyCode;

        private const string _name = "Cameroon";
        private const string _countryCode = "CM";
        private const int _currencyCode = 950;

        public Cameroon() { }
    }
}
