namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Congo : SingletonCountryBase<Congo>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Congo";
        private const string _countryCode = "CD";

        public Congo() { }
    }
}

