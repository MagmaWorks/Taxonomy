namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mauritius : SingletonCountryBase<Mauritius>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mauritius";
        private const string _countryCode = "MU";

        public Mauritius() { }
    }
}

