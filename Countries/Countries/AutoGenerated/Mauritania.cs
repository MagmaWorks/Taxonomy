namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mauritania : SingletonCountryBase<Mauritania>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mauritania";
        private const string _countryCode = "MR";

        public Mauritania() { }
    }
}

