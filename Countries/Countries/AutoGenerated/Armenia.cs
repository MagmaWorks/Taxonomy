namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Armenia : SingletonCountryBase<Armenia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Armenia";
        private const string _countryCode = "AM";

        public Armenia() { }
    }
}

