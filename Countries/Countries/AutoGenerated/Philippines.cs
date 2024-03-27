namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Philippines : SingletonCountryBase<Philippines>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Philippines";
        private const string _countryCode = "PH";

        public Philippines() { }
    }
}

