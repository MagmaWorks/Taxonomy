namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mayotte : SingletonCountryBase<Mayotte>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mayotte";
        private const string _countryCode = "YT";

        public Mayotte() { }
    }
}

