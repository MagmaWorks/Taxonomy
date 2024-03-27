namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Ghana : SingletonCountryBase<Ghana>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Ghana";
        private const string _countryCode = "GH";

        public Ghana() { }
    }
}

