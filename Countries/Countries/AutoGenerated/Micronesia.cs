namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Micronesia : SingletonCountryBase<Micronesia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Micronesia";
        private const string _countryCode = "FM";

        public Micronesia() { }
    }
}

