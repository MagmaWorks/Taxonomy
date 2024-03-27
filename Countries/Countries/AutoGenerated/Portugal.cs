namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Portugal : SingletonCountryBase<Portugal>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Portugal";
        private const string _countryCode = "PT";

        public Portugal() { }
    }
}

