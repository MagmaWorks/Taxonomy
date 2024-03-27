namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Niger : SingletonCountryBase<Niger>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Niger";
        private const string _countryCode = "NE";

        public Niger() { }
    }
}

