namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Réunion : SingletonCountryBase<Réunion>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Réunion";
        private const string _countryCode = "RE";

        public Réunion() { }
    }
}

