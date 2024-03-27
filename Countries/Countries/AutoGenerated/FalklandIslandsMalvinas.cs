namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class FalklandIslandsMalvinas : SingletonCountryBase<FalklandIslandsMalvinas>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Falkland Islands (Malvinas)";
        private const string _countryCode = "FK";

        public FalklandIslandsMalvinas() { }
    }
}

