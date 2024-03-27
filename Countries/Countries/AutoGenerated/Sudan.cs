namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Sudan : SingletonCountryBase<Sudan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sudan";
        private const string _countryCode = "SD";

        public Sudan() { }
    }
}

