namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Uzbekistan : SingletonCountryBase<Uzbekistan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Uzbekistan";
        private const string _countryCode = "UZ";

        public Uzbekistan() { }
    }
}

