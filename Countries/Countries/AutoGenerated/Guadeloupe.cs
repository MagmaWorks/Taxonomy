namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guadeloupe : SingletonCountryBase<Guadeloupe>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guadeloupe";
        private const string _countryCode = "GP";

        public Guadeloupe() { }
    }
}

