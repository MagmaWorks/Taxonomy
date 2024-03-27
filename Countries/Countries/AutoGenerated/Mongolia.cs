namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mongolia : SingletonCountryBase<Mongolia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mongolia";
        private const string _countryCode = "MN";

        public Mongolia() { }
    }
}

