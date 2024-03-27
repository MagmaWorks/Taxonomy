namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SriLanka : SingletonCountryBase<SriLanka>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sri Lanka";
        private const string _countryCode = "LK";

        public SriLanka() { }
    }
}

