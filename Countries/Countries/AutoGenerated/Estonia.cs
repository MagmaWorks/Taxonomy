namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Estonia : SingletonCountryBase<Estonia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Estonia";
        private const string _countryCode = "EE";

        public Estonia() { }
    }
}

