namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Nicaragua : SingletonCountryBase<Nicaragua>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Nicaragua";
        private const string _countryCode = "NI";

        public Nicaragua() { }
    }
}

