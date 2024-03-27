namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Peru : SingletonCountryBase<Peru>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Peru";
        private const string _countryCode = "PE";

        public Peru() { }
    }
}

