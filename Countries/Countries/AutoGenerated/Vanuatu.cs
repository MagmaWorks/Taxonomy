namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Vanuatu : SingletonCountryBase<Vanuatu>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Vanuatu";
        private const string _countryCode = "VU";

        public Vanuatu() { }
    }
}

