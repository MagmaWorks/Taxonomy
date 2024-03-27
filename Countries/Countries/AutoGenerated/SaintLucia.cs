namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintLucia : SingletonCountryBase<SaintLucia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Lucia";
        private const string _countryCode = "LC";

        public SaintLucia() { }
    }
}

