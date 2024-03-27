namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tunisia : SingletonCountryBase<Tunisia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tunisia";
        private const string _countryCode = "TN";

        public Tunisia() { }
    }
}

