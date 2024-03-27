namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bahamas : SingletonCountryBase<Bahamas>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bahamas";
        private const string _countryCode = "BS";

        public Bahamas() { }
    }
}

