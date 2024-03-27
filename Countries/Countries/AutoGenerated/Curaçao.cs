namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Curaçao : SingletonCountryBase<Curaçao>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Curaçao";
        private const string _countryCode = "CW";

        public Curaçao() { }
    }
}

