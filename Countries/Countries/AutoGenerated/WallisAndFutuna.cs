namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class WallisAndFutuna : SingletonCountryBase<WallisAndFutuna>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Wallis and Futuna";
        private const string _countryCode = "WF";

        public WallisAndFutuna() { }
    }
}

