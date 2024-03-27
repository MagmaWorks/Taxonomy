namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tajikistan : SingletonCountryBase<Tajikistan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tajikistan";
        private const string _countryCode = "TJ";

        public Tajikistan() { }
    }
}

