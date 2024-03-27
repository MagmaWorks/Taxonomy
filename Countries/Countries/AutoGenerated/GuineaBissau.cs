namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class GuineaBissau : SingletonCountryBase<GuineaBissau>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guinea-Bissau";
        private const string _countryCode = "GW";

        public GuineaBissau() { }
    }
}

