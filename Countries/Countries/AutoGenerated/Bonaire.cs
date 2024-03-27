namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bonaire : SingletonCountryBase<Bonaire>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bonaire";
        private const string _countryCode = "BQ";

        public Bonaire() { }
    }
}

