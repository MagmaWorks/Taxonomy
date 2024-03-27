namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Greece : SingletonCountryBase<Greece>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Greece";
        private const string _countryCode = "GR";

        public Greece() { }
    }
}

