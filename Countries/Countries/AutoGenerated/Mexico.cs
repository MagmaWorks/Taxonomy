namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mexico : SingletonCountryBase<Mexico>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mexico";
        private const string _countryCode = "MX";

        public Mexico() { }
    }
}

