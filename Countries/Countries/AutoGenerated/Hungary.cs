namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Hungary : SingletonCountryBase<Hungary>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Hungary";
        private const string _countryCode = "HU";

        public Hungary() { }
    }
}

