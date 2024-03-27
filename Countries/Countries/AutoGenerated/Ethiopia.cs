namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Ethiopia : SingletonCountryBase<Ethiopia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Ethiopia";
        private const string _countryCode = "ET";

        public Ethiopia() { }
    }
}

