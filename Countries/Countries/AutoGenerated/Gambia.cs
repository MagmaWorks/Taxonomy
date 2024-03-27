namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Gambia : SingletonCountryBase<Gambia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Gambia";
        private const string _countryCode = "GM";

        public Gambia() { }
    }
}

