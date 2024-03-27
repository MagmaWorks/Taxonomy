namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guyana : SingletonCountryBase<Guyana>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guyana";
        private const string _countryCode = "GY";

        public Guyana() { }
    }
}

