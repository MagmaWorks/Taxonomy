namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Gabon : SingletonCountryBase<Gabon>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Gabon";
        private const string _countryCode = "GA";

        public Gabon() { }
    }
}

