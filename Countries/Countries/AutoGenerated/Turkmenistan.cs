namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Turkmenistan : SingletonCountryBase<Turkmenistan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Turkmenistan";
        private const string _countryCode = "TM";

        public Turkmenistan() { }
    }
}

