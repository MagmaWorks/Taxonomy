namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Grenada : SingletonCountryBase<Grenada>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Grenada";
        private const string _countryCode = "GD";

        public Grenada() { }
    }
}

