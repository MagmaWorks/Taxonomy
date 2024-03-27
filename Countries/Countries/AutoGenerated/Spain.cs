namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Spain : SingletonCountryBase<Spain>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Spain";
        private const string _countryCode = "ES";

        public Spain() { }
    }
}

