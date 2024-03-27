namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Azerbaijan : SingletonCountryBase<Azerbaijan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Azerbaijan";
        private const string _countryCode = "AZ";

        public Azerbaijan() { }
    }
}

