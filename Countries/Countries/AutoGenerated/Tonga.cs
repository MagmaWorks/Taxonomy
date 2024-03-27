namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tonga : SingletonCountryBase<Tonga>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tonga";
        private const string _countryCode = "TO";

        public Tonga() { }
    }
}

