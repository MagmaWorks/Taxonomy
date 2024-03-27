namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class FrenchPolynesia : SingletonCountryBase<FrenchPolynesia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "French Polynesia";
        private const string _countryCode = "PF";

        public FrenchPolynesia() { }
    }
}

