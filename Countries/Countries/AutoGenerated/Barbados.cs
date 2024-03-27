namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Barbados : SingletonCountryBase<Barbados>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Barbados";
        private const string _countryCode = "BB";

        public Barbados() { }
    }
}

