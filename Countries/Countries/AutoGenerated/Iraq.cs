namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Iraq : SingletonCountryBase<Iraq>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Iraq";
        private const string _countryCode = "IQ";

        public Iraq() { }
    }
}

