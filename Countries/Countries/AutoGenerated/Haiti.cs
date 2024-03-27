namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Haiti : SingletonCountryBase<Haiti>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Haiti";
        private const string _countryCode = "HT";

        public Haiti() { }
    }
}

