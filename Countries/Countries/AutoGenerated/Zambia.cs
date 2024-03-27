namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Zambia : SingletonCountryBase<Zambia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Zambia";
        private const string _countryCode = "ZM";

        public Zambia() { }
    }
}

