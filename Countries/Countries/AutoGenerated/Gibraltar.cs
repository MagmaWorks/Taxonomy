namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Gibraltar : SingletonCountryBase<Gibraltar>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Gibraltar";
        private const string _countryCode = "GI";

        public Gibraltar() { }
    }
}

