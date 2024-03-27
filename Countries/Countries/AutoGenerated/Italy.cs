namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Italy : SingletonCountryBase<Italy>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Italy";
        private const string _countryCode = "IT";

        public Italy() { }
    }
}

