namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class India : SingletonCountryBase<India>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "India";
        private const string _countryCode = "IN";

        public India() { }
    }
}

