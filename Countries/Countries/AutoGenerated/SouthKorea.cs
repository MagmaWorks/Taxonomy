namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SouthKorea : SingletonCountryBase<SouthKorea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "South Korea";
        private const string _countryCode = "KR";

        public SouthKorea() { }
    }
}

